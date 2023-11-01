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

namespace Cobit_19.Business.Reports
{
    public class ReportProvider
    {
        private readonly AppDbContext _dbContext;
        private readonly AuditProvider _auditProvider;
        private readonly ObjectiveAuditProvider _objectiveAuditProvider;
        public ReportProvider(AppDbContext dbContext, AuditProvider auditProvider, ObjectiveAuditProvider objectiveAuditProvider)
        {
            _dbContext = dbContext;
            _auditProvider = auditProvider;
            _objectiveAuditProvider = objectiveAuditProvider;
        }

        public MemoryStream createObjectiveAuditReport(int objectiveAuditId)
        {
            var auditJSON = _objectiveAuditProvider.getAuditJSON(objectiveAuditId);
            var auditObject = AuditJSONParsingService.parseAuditTemplate(auditJSON);

            ObjectiveAuditReport report = new ObjectiveAuditReport();
            var memmoryStream = report.create(auditObject);

            return memmoryStream;
        }

        public async Task<MemoryStream> createGoalsCascadeReport(int auditId, string chartImage)
        {
            var designfactors = await _auditProvider.getDesignFactorsAsync(auditId);

            GoalsCascadeReport goalsCascadeReport = new GoalsCascadeReport();
            var memoryStream = goalsCascadeReport.create(designfactors, chartImage);

            return memoryStream;
        }
    }
}
