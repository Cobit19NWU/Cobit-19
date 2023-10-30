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
        public ReportProvider(AppDbContext dbContext, AuditProvider auditProvider)
        {
            _dbContext = dbContext;
            _auditProvider = auditProvider;
        }

        public MemoryStream createDFReport()
        {
            return new MemoryStream();
        }

        public MemoryStream createCanvasReport()
        {
            return new MemoryStream();
        }
        public MemoryStream createObjectiveAuditReport(IList<ObjectiveAuditDto> objectiveAudits)
        {
            PdfDocument pdfDocument = new PdfDocument();

            pdfDocument.PageSettings.Size = PdfPageSize.A4;

            PdfPage page = pdfDocument.Pages.Add();

            PdfGraphics graphics = page.Graphics;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

            graphics.DrawString("Objective Audits Report", font, PdfBrushes.Black, new Syncfusion.Drawing.PointF(150, 0));

            PdfGrid table = new PdfGrid();

            table.Columns.Add(3);

            table.Headers.Add(1);

            PdfGridRow tableHeader = table.Headers[0];

            tableHeader.Cells[0].Value = "Objective Code";
            tableHeader.Cells[1].Value = "Objective Name";
            tableHeader.Cells[2].Value = "Maturity Level";

            foreach (var objAudit in objectiveAudits)
            {
                PdfGridRow tableRow = table.Rows.Add();
                PdfGridRowStyle tableRowStyle = new PdfGridRowStyle();
                var auditString = objAudit.UserAuditObject;
                var auditObject = AuditJSONParsingService.parseAuditTemplate(auditString);

                tableRowStyle.BackgroundBrush = PdfBrushes.LightYellow;
                tableRowStyle.Font = new PdfStandardFont(PdfFontFamily.Courier, 15);
                tableRowStyle.TextBrush = PdfBrushes.Blue;
                tableRowStyle.TextPen = PdfPens.Pink;

                PdfStringFormat format = new PdfStringFormat();
                format.Alignment = PdfTextAlignment.Center;
                format.LineAlignment = PdfVerticalAlignment.Middle;

                tableRow.Height = 25;
                tableRow.Cells[0].StringFormat = format;
                tableRow.Cells[1].StringFormat = format;
                tableRow.Cells[2].StringFormat = format;
                tableRow.Cells[0].Value = auditObject.objectiveName;
                tableRow.Cells[1].Value = objAudit.Objective.Description;
                tableRow.Cells[2].Value = auditObject.maturityLevel.ToString();
            }

            table.ApplyBuiltinStyle(PdfGridBuiltinStyle.GridTable4Accent1);
            table.Draw(page, new Syncfusion.Drawing.PointF(10, 40));

            MemoryStream stream = new MemoryStream();

            pdfDocument.Save(stream);
            pdfDocument.Close();

            return stream;
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
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
