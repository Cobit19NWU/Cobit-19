using Cobit_19.Data;

namespace Cobit_19.Business.Reports
{
    public class ReportProvider
    {
        private readonly AppDbContext _dbContext;
        public ReportProvider(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MemoryStream createDFReport()
        {
            return new MemoryStream();
        }

        public MemoryStream createCanvasReport()
        {
            return new MemoryStream();
        }
        public MemoryStream createObjectiveAuditReport()
        {
            return new MemoryStream();
        }
    }
}
