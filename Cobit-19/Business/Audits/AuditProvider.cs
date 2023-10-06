using AutoMapper;
using Cobit_19.Business.ObjectiveAudits;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Cobit_19.Shared.Enums;
using Microsoft.EntityFrameworkCore;

namespace Cobit_19.Business.Audits
{
    public class AuditProvider
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;
        private static readonly object _lock = new object();
        private readonly ObjectiveAuditProvider _objectiveAuditProvider;
        public AuditProvider(IMapper mapper, AppDbContext dbContext, ObjectiveAuditProvider objectiveAuditProvider)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _objectiveAuditProvider = objectiveAuditProvider;
        }

        // Get audit by id with focus area and design factors
        public async Task<AuditDto> getAsync(int id)
        {
            var quary = await _dbContext.Audits.FindAsync(id);
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
                    };
                    _dbContext.Answers.Add(answer);
                }
            }

            //Create ObjectiveAudits
            var objectives = await getObjectivesAsync();
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
            }

            var auditMember = new AuditMemberModel
            {
                ApplicationUserID = audit.ApplicationUserID,
                AuditID = audit.ID
            };

            _dbContext.AuditMembers.Add(auditMember);

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

    }
}
