﻿using AutoMapper;
using Cobit_19.Business.ObjectiveAudits;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Cobit_19.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using Cobit_19.Business.Admin;
using Microsoft.AspNetCore.Identity;

namespace Cobit_19.Business.Audits
{
    public class AuditProvider
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;
        private static readonly object _lock = new object();
        private readonly ObjectiveAuditProvider _objectiveAuditProvider;
        private readonly UserManagementProvider _userManagementProvider;
        private readonly UserManager<ApplicationUser> _userManager;
        public AuditProvider(IMapper mapper, AppDbContext dbContext, ObjectiveAuditProvider objectiveAuditProvider, UserManagementProvider userManagementProvider, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _objectiveAuditProvider = objectiveAuditProvider;
            _userManagementProvider = userManagementProvider;
            _userManager = userManager;
        }

        // Get audit by id with focus area and design factors
        public async Task<AuditDto> getAsync(int id)
        {
            var quary = await _dbContext.Audits
                .Include(a => a.ApplicationUser)
                .Include(a => a.FocusArea)
                .Where(a => a.ID == id)
                .FirstOrDefaultAsync();

            return _mapper.Map<AuditDto>(quary);
        }

        // Get all audits
        public async Task<IEnumerable<AuditDto>> getAllAsync()
        {
            var quary = await _dbContext.Audits
                .ToListAsync();
            return _mapper.Map<IEnumerable<AuditDto>>(quary);
        }

        public async Task<IEnumerable<AuditDto>> getAllByUserAsync(string userId)
        {
            var quary = await _dbContext.Audits
                .Where(a => a.ApplicationUserID == userId)
                .ToListAsync();
            return _mapper.Map<IEnumerable<AuditDto>>(quary);
        }

        public async Task<IEnumerable<AuditDto>> getAllByFocusAreaAsync(int focusAreaId)
        {
            var quary = await _dbContext.Audits
                .Where(a => a.FocusAreaID == focusAreaId)
                .ToListAsync();
            return _mapper.Map<IEnumerable<AuditDto>>(quary);
        }

        public async Task<List<DesignFactorDto>> getDesignFactorsAsync(int auditId)
        {
            var DesignFactors = await _dbContext.FocusAreas
                .Where(f => f.Audits.Any(a => a.ID == auditId))
                .SelectMany(f => f.DesignFactors)
                .Include(df => df.Questions)
                .ToListAsync();

            return _mapper.Map<List<DesignFactorDto>>(DesignFactors);
        }

        public async Task<DesignFactorDto> getDesignFactorFullAsync(int auditId, int designFactorId)
        {
            var DesignFactor = await _dbContext.FocusAreas
                .Where(f => f.Audits.Any(a => a.ID == auditId))
                .SelectMany(f => f.DesignFactors)
                .Include(df => df.Questions)
                    .ThenInclude(q => q.Answers.Where(a => a.AuditID == auditId))
                .Include(df => df.Questions)
                    .ThenInclude(q => q.Maps)
                        .ThenInclude(m => m.Objective)
                .FirstOrDefaultAsync(df => df.ID == designFactorId);

            return _mapper.Map<DesignFactorDto>(DesignFactor);
        }

        // This may be more usefull in ObjectiveProvider
        public async Task<List<ObjectiveDto>> getObjectivesAsync()
        {
            var objectives = await _dbContext.Objectives
                .ToListAsync();

            return _mapper.Map<List<ObjectiveDto>>(objectives);
        }

        public async Task<AuditDto> createAsync(AuditEditorDto auditEditorDto)
        {
            // Create Audit
            var audit = _mapper.Map<AuditModel>(auditEditorDto);
            var adminUsers = await _userManagementProvider.GetAdminUsersAsync();
            var user = new UserDto()
            {
                ID = auditEditorDto.UserID
            };
            var userRole = await _userManagementProvider.getUserRoleAsync(user);

            await _dbContext.Audits.AddAsync(audit);
            await _dbContext.SaveChangesAsync();

            // Create Answers
            var DesignFactors = await getDesignFactorsAsync(audit.ID);
            foreach (var DF in DesignFactors)
            {
                foreach (var question in DF.Questions)
                {
                    var answer = new AnswerModel
                    {
                        AuditID = audit.ID,
                        QuestionID = question.ID,
                        Answer = question.BaseAnswer,
                        AnswerRange = question.AnswerRange,
                        Odds = question.Odds,
                    };
                    _dbContext.Answers.Add(answer);
                }
            }

            //Create ObjectiveAudits
            var objectiveTemplates = await _objectiveAuditProvider.getAllObjectiveTemplatesAsync();
            foreach (var objTemplate in objectiveTemplates)
            {
                var objAudit = new ObjectiveAuditModel
                {
                    AuditID = audit.ID,
                    ObjectiveID = objTemplate.ObjectiveID,
                    ApplicationUserID = audit.ApplicationUserID,
                    DateCreated = DateTime.Now,
                    Selected = false,
                    Status = AuditStatus.NotStarted,
                    UserAuditObject = objTemplate.AuditObject
                };

                _dbContext.ObjectiveAudits.Add(objAudit);
                _dbContext.SaveChanges();

                var objAuditID = objAudit.ID;

                foreach (var adminUser in adminUsers)
                {
                    var objAuditMember = new ObjectiveAuditMembersModel
                    {
                        ApplicationUserID = adminUser.ID,
                        ObjectiveAuditID = objAuditID,
                        DateAdded = DateTime.Now
                    };

                    _dbContext.ObjectiveAuditMembers.Add(objAuditMember);
                }

                if (userRole == "Head Auditor")
                {
                    var objAuditMember = new ObjectiveAuditMembersModel
                    {
                        ApplicationUserID = user.ID,
                        ObjectiveAuditID = objAuditID,
                        DateAdded = DateTime.Now
                    };

                    _dbContext.ObjectiveAuditMembers.Add(objAuditMember);
                }
            }


            foreach (var adminUser in adminUsers)
            {
                var auditMember = new AuditMemberModel
                {
                    ApplicationUserID = adminUser.ID,
                    AuditID = audit.ID
                };

                _dbContext.AuditMembers.Add(auditMember);
            }

            if (userRole == "Head Auditor")
            {
                var auditMember = new AuditMemberModel
                {
                    ApplicationUserID = user.ID,
                    AuditID = audit.ID
                };

                _dbContext.AuditMembers.Add(auditMember);
            }

            await _dbContext.SaveChangesAsync();

            return _mapper.Map<AuditDto>(audit);
        }

        public async Task<AuditDto> deleteAsync(int id)
        {
            var audit = _dbContext.Audits.Find(id);
            if(audit == null)
            {
                return null;
            }

            lock (_lock)
            {
                // Remove answers
                var answers = _dbContext.Answers.Where(a => a.AuditID == audit.ID).ToList();
                foreach (var answer in answers)
                {
                    _dbContext.Answers.Remove(answer);
                }

                //Remove ObjectiveAudits
                var objectiveAudits = _dbContext.ObjectiveAudits.Where(oa => oa.AuditID == audit.ID).ToList();
                foreach (var objectiveAudit in objectiveAudits)
                {
                    _dbContext.ObjectiveAudits.Remove(objectiveAudit);
                }

                // Remove Audit
                _dbContext.Audits.Remove(audit);
                _dbContext.SaveChangesAsync();
            }

            return _mapper.Map<AuditDto>(audit);
        }

        public async Task<AuditDto> updateAsync(AuditEditorDto auditEditorDto)
        {
            var audit = _dbContext.Audits.Find(auditEditorDto.ID);
            if(audit == null)
            {
                return null;
            }

            _mapper.Map(auditEditorDto, audit);

            if (audit.Status == AuditStatus.InProgress)
            {
                audit.DateCompleted = null;
            }
            else if (audit.Status == AuditStatus.Completed)
            {
                audit.DateCompleted = DateTime.Now;
            }

            lock (_lock)
            {
                _dbContext.Audits.Update(audit);

                _dbContext.SaveChangesAsync();
            }

            return _mapper.Map<AuditDto>(audit);
        }

        public async Task<AnswerDto> updateAnswerAsync(AnswerEditorDto answerEditorDto)
        {
            var answer = _dbContext.Answers.Find(answerEditorDto.AuditID, answerEditorDto.QuestionID);
            if(answer == null)
            {
                return null;
            }

            lock (_lock)
            {
                _mapper.Map(answerEditorDto, answer);

                _dbContext.Answers.Update(answer);

                _dbContext.SaveChangesAsync();
            }

            return _mapper.Map<AnswerDto>(answer);
        }

        public async Task<bool> IsUserInAuditAsync(int AuditID, string ApplicationUserID)
        {
            var checkQuery = _dbContext.AuditMembers
                .Where(auditMember => auditMember.AuditID == AuditID && auditMember.ApplicationUserID == ApplicationUserID);

            var isUserInAudit = await checkQuery.AnyAsync();

            return isUserInAudit;
        }

        public List<AuditMemberDto> getAuditMembers(int AuditID)
        {
            var users = _dbContext.AuditMembers.Where(a => a.AuditID == AuditID).ToList();
            return _mapper.Map<List<AuditMemberDto>>(users);
        }

        public async Task addAuditMemberAsync(AuditMemberDto auditMemberDto)
        {
            var auditMember = _mapper.Map<AuditMemberModel>(auditMemberDto);

            var user = await _userManagementProvider.GetUserDtoByIdAsync(auditMemberDto.ApplicationUserID);

            var userRole = await _userManagementProvider.getUserRoleAsync(user);

            _dbContext.AuditMembers.Add(auditMember);

            if (userRole == "Head Auditor" || userRole == "Client")
            {
                var objAudits = _objectiveAuditProvider.getAll(auditMemberDto.AuditID);
                foreach (var objAudit in objAudits)
                {
                    var objAuditMemberModel = new ObjectiveAuditMembersModel
                    {
                        ObjectiveAuditID = objAudit.ID,
                        ApplicationUserID = auditMemberDto.ApplicationUserID,
                        DateAdded = DateTime.Now
                    };

                    _dbContext.ObjectiveAuditMembers.Add(objAuditMemberModel);
                }
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task<UserDto> deleteAuditMemberAsync(int auditId, string userId)
        {
            if (!await IsUserInAuditAsync(auditId, userId))
            {
                return null;
            }

            var objAudits = _objectiveAuditProvider.getObjectiveAuditsForUser(userId ,auditId);
            foreach (var objAudit in objAudits)
            {
                var objAuditMemberModel = new ObjectiveAuditMembersModel
                {
                    ObjectiveAuditID = objAudit.ID,
                    ApplicationUserID = userId,
                    DateAdded = DateTime.Now
                };

                _dbContext.ObjectiveAuditMembers.Remove(objAuditMemberModel);
            }

            var member = _dbContext.AuditMembers.Where(a => a.AuditID == auditId && a.ApplicationUserID == userId).FirstOrDefault();

            var res = _dbContext.AuditMembers.Remove(member);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<UserDto>(res);
        }

        public async Task addMemberToAllAudits(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var userID = user.Id;

            var audits = await getAllAsync();

            foreach(var audit in audits)
            {
                AuditMemberModel auditMember = new AuditMemberModel
                {
                    ApplicationUserID = userID,
                    AuditID = audit.ID
                };

                await _dbContext.AuditMembers.AddAsync(auditMember);
            }

            await _dbContext.SaveChangesAsync();
        }

    }
}
