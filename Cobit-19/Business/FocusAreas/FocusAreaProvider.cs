using AutoMapper;
using Cobit_19.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using Cobit_19.Data;
using Cobit_19.Shared.Enums;
using Cobit_19.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Cobit_19.Business.FocusAreas
{
    public class FocusAreaProvider
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public FocusAreaProvider(IMapper mapper, AppDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public IEnumerable<FocusAreaDto> GetFocusAreasByUserID(string userID)
        {
            var subscriptions = _dbContext.Subscriptions
                .Where(sub => sub.ApplicationUserID == userID)
                .Select(sub => sub.FocusAreaID)
                .ToList();

            var focusAreaList = _dbContext.FocusAreas
                .Where(fa => subscriptions.Contains(fa.ID))
                .ToList();

            return _mapper.Map<IEnumerable<FocusAreaDto>>(focusAreaList);
        }

        public IEnumerable<AuditDto> GetAuditsForFocusAreaByUserID(string userID, int focusAreaID)
        {
            var auditSubs = _dbContext.AuditMembers
                .Where(auditSub => auditSub.ApplicationUserID == userID)
                .Select(auditSub => auditSub.AuditID)
                .ToList();

            var audits = _dbContext.Audits
                .Where(audit => auditSubs.Contains(audit.ID) && audit.FocusAreaID == focusAreaID)
                .ToList();

            return _mapper.Map<IEnumerable<AuditDto>>(audits);
        }

        public IEnumerable<FocusAreaDto> GetAllFocusAreas()
        {
            var query = _dbContext.FocusAreas.ToList();

            return _mapper.Map<IEnumerable<FocusAreaDto>>(query);
        }

        public async Task<List<AuditDto>> GetAllAuditsForFocusArea(int focusAreaID)
        {
            var query = await _dbContext.Audits.Where(audit => audit.FocusAreaID == focusAreaID).ToListAsync();

            return _mapper.Map<List<AuditDto>>(query);
        }

        public string GetFocusAreaCompletionStatus(string userID, int focusAreaID)
        {
            var audit = GetLastAuditForFocusAreaByUserID(userID, focusAreaID);

            if (audit == null)
            {
                return "Not Started";
            }

            if (audit.Status == AuditStatus.NotStarted)
            {
                return "Not Started";
            }
            else if (audit.Status == AuditStatus.InProgress)
            {
                return "In Progress";
            }
            else if (audit.Status == AuditStatus.Completed)
            {
                return "Completed";
            }
            else
            {
                return null;
            }
        }

        public string GetFocusAreaActivityStatus(string userID, int focusAreaID)
        {
            var audits = GetAuditsForFocusAreaByUserID(userID, focusAreaID);
            bool focusAreaActivityStatus = false;

            foreach(var audit in audits)
            {
                if (audit.Status == AuditStatus.InProgress || audit.Status == AuditStatus.NotStarted)
                {
                    focusAreaActivityStatus = true;
                }
            }

            if (focusAreaActivityStatus)
            {
                return "Active";
            }
            else
            {
                return "Inactive";
            }
        }

        public AuditDto GetLastAuditForFocusAreaByUserID(string userID, int focusAreaID)
        {
            var auditSubs = _dbContext.AuditMembers
                .Where(auditSub => auditSub.ApplicationUserID == userID)
                .Select(auditSub => auditSub.AuditID)
                .ToList();

            var audit = _dbContext.Audits
                .Where(audit => auditSubs.Contains(audit.ID) && audit.FocusAreaID == focusAreaID)
                .OrderByDescending(audit => audit.DateCreated)
                .FirstOrDefault();

            return _mapper.Map<AuditDto>(audit);
        }

        public DesignFactorDto GetNextDesignFactor(int FocusAreaID, int designFactorID)
        {
            var designFactors = _dbContext.FocusAreas
                .Where(fa => fa.ID == FocusAreaID)
                .SelectMany(fa => fa.DesignFactors)
                .OrderBy(df => df.ID)
                .ToList();

            var currentDesignFactor = designFactors.Find(df => df.ID == designFactorID);

            if (currentDesignFactor == null)
            {
                return null;
            }

            int pos = designFactors.IndexOf(currentDesignFactor);

            if (pos >= designFactors.Count - 1)
            {
                return null;
            }

            var value = designFactors.ElementAtOrDefault(pos + 1);

            return _mapper.Map<DesignFactorDto>(value);
        }

        public DesignFactorDto GetPrevDesignFactor(int FocusAreaID, int designFactorID)
        {
            var designFactors = _dbContext.FocusAreas
                .Where(fa => fa.ID == FocusAreaID)
                .SelectMany(fa => fa.DesignFactors)
                .OrderBy(df => df.ID)
                .ToList();

            var currentDesignFactor = designFactors.Find(df => df.ID == designFactorID);

            if (currentDesignFactor == null)
            {
                return null;
            }

            int pos = designFactors.IndexOf(currentDesignFactor);

            if (pos <= 0)
            {
                return null;
            }

            var value = designFactors.ElementAtOrDefault(pos - 1);

            return _mapper.Map<DesignFactorDto>(value);
        }

        public async Task AddUserToFocusAreaAsync(int focusAreaID, string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var userID = user.Id;

            SubscriptionModel newSub = new SubscriptionModel
            {
                ApplicationUserID = userID,
                FocusAreaID = focusAreaID,
            };

            await _dbContext.Subscriptions.AddAsync(newSub);

            await _dbContext.SaveChangesAsync();
        }


    }
}
