using Cobit_19.Data;
using Cobit_19.Shared.Dtos;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Configuration;
using Cobit_19.Business.ObjectiveAudits;
using System.Drawing;
using Cobit_19.Business.Audits;
using NuGet.DependencyResolver;
using static Cobit_19.Business.Reports.ObjectiveAuditData;
using Cobit_19.Business.Admin;

namespace Cobit_19.Business.Reports
{
    public class ReportProvider
    {
        private readonly AppDbContext _dbContext;
        private readonly AuditProvider _auditProvider;
        private readonly ObjectiveAuditProvider _objectiveAuditProvider;
        private readonly UserManagementProvider _userManagementProvider;

        public ReportProvider(AppDbContext dbContext, AuditProvider auditProvider, ObjectiveAuditProvider objectiveAuditProvider, UserManagementProvider userManagementProvider)
        {
            _dbContext = dbContext;
            _auditProvider = auditProvider;
            _objectiveAuditProvider = objectiveAuditProvider;
            _userManagementProvider = userManagementProvider;
        }

        public async Task<MemoryStream> createObjectiveAuditReport(int objectiveAuditId)
        {
            var auditJSON = _objectiveAuditProvider.getAuditJSON(objectiveAuditId);
            var auditObject = AuditJSONParsingService.parseAuditTemplate(auditJSON);

            var AuditID = _objectiveAuditProvider.getAuditIdFromObjectiveAuditID(objectiveAuditId);
            var assesment = await _auditProvider.getAsync(AuditID);
            
            var objectiveAuditMembers = _objectiveAuditProvider.getMembersByObjectiveAuditID(objectiveAuditId);

            List<string> users = new List<string>();
            foreach(var auditMember in objectiveAuditMembers)
            {
                var user = _userManagementProvider.GetUserDtoByIdAsync(auditMember.ApplicationUserID).Result;
                users.Add(user.UserName);
            }

            AssesmentData data = new AssesmentData()
            {
                Organization = "NWU",
                Assessment = "COBIT 2019",
                Lead = assesment.User.UserName,
                FocusArea = assesment.FocusArea.Name,
                Auditors = users,
                AuditName = assesment.Name,
                Date = assesment.DateCreated.Date,
                Maturity = auditObject.maturityLevel,
                Target = 4
            };


            ObjectiveAuditReport report = new ObjectiveAuditReport();
            var memmoryStream = report.create(auditObject, data);

            return memmoryStream;
        }

        public async Task<MemoryStream> createGoalsCascadeReport(int auditId, string chartImage)
        {
            var designfactors = await _auditProvider.getDesignFactorsAsync(auditId);

            var audit = await _auditProvider.getAsync(auditId);

            GoalsCascadeReport goalsCascadeReport = new GoalsCascadeReport();
            var memoryStream = goalsCascadeReport.create(designfactors, chartImage, audit);

            return memoryStream;
        }
    }
}
