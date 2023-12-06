using Cobit_19.Business.Audits;
using Cobit_19.Data.Models;
using Cobit_19.Pages.Audit;
using Cobit_19.Shared.Dtos;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Xmp;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static Cobit_19.Business.Reports.GoalsCascadeData;

namespace Cobit_19.Business.Reports
{
    
    public class GoalsCascadeReport
    {
        private PdfDocument _pdfDocument;

        public GoalsCascadeReport()
        {
            _pdfDocument = new PdfDocument();
            _pdfDocument.PageSettings.Size = PdfPageSize.A4;
            _pdfDocument.PageSettings.Orientation = PdfPageOrientation.Landscape;
        }

        public MemoryStream create(List<DesignFactorDto> designFactors, string chartBase64, AuditDto audit, ApplicationUser auditCreator)
        {
            AssesmentData data = new AssesmentData()
            {
                Organization = "NWU",
                Assessment = "COBIT 2019",
                Lead = auditCreator.FirstName +  " " + auditCreator.LastName,
                FocusArea = audit.FocusArea.Name,
                Maturity = 1,
                Date = audit.DateCreated
            };


            addCoverPager("The corporation manufactures goods, is a large enterprise, is very cost conscious, and desires to be a cost leader in its market. The enterprise considers I&T purely a supporting function for efficient and effective operations. Although IT is a supporting function, the enterprise is critically dependent on it. The enterprise takes a traditional approach to new development and operations and is quite hesitant to adopt new technologies. Recently, the enterprise was confronted with a malware attack and suffered from several operational IT problems. The enterprise houses and operates critical IT equipment in-house.", data);

            addDesignFactorPage("1.1 Enterprise Strategy (Design Factor 1)", "", designFactors[0]);
            addDesignFactorPage("1.2 Enterprise Goals (Design Factor 2)", "", designFactors[1]);
            addDesignFactorPage("1.3 Risk profile (Design Factor 3)", "", designFactors[2]);
            addDesignFactorPage("1.4 I&T-related issues (Design Factor 4)", "", designFactors[3]);
            addDesignFactorPage("1.5 Threat landscape (Design Factor 5)", "", designFactors[4]);
            addDesignFactorPage("1.6 Compliance requirements (Design Factor 6)", "", designFactors[5]);
            addDesignFactorPage("1.7 Role of IT (Design Factor 7)", "", designFactors[6]);
            addDesignFactorPage("1.8 Sourcing model for IT (Design Factor 8)", "", designFactors[7]);
            addDesignFactorPage("1.9 IT implementation methods (Design Factor 9)", "", designFactors[8]);
            addDesignFactorPage("1.10 Technology adoption strategy (Design Factor 10)", "", designFactors[9]);

            addSummary("Governance and Management Objectives ", "This section adds the governance and management priorities resulting from step 1. This synthesis results in the following adjusted priorities for governance and management objectives in the organisations governance system.", chartBase64);

            MemoryStream stream = new MemoryStream();

            _pdfDocument.Save(stream);
            _pdfDocument.Close();

            return stream;

        }

        private void addCoverPager(string statement, AssesmentData assesmentData, string header = "Objective Audits Report")
        {
            _pdfDocument.PageSettings.Orientation = PdfPageOrientation.Portrait;
            PdfPage page = _pdfDocument.Pages.Add();

            //LOGO
            var logodim = new PointF(500, 280);
            PdfGraphics graphics = page.Graphics;
            string path = Directory.GetCurrentDirectory();
            FileStream imageStream = new FileStream(path + "/wwwroot/images/CobitWatermark.jpg", FileMode.Open, FileAccess.Read);
            PdfImage logo = new PdfBitmap(imageStream);
            graphics.DrawImage(logo, 0,0,logodim.X,logodim.Y);

            // HEADER            
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 26, PdfFontStyle.Bold);
            SizeF sizeF = font.MeasureString(header);
            graphics.DrawString(header, font, PdfBrushes.Black, new PointF(0, logodim.Y + 30));

            //INFOGRID
            PdfGrid infoTable = new PdfGrid();
            infoTable.Columns.Add(2);

            PdfGridCellStyle cellStyle = new PdfGridCellStyle();
            cellStyle.Borders.All = PdfPens.Transparent;
            cellStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10, PdfFontStyle.Bold);

            PdfStringFormat format = new PdfStringFormat();
            format.LineAlignment = PdfVerticalAlignment.Middle;

            PdfGridRow gridRow = infoTable.Rows.Add();
            gridRow.Height = 25;
            gridRow.Cells[0].Value = "Organization:  " + assesmentData.Organization;
            gridRow.Cells[0].Style = cellStyle;
            gridRow.Cells[1].Value = "Assessment:    " + assesmentData.Assessment;
            gridRow.Cells[1].Style = cellStyle;

            gridRow = infoTable.Rows.Add();
            gridRow.Height = 25;
            gridRow.Cells[0].Value = "Lead Assessor: " + assesmentData.Lead;
            gridRow.Cells[0].Style = cellStyle;
            gridRow.Cells[1].Value = "Focus Area:    " + assesmentData.FocusArea;
            gridRow.Cells[1].Style = cellStyle;
            gridRow.Style = cellStyle;

            gridRow = infoTable.Rows.Add();
            gridRow.Height = 25;
            gridRow.Cells[0].Value = "Maturity Level:" + assesmentData.Maturity.ToString();
            gridRow.Cells[0].Style = cellStyle;
            gridRow.Cells[1].Value = "Date Created:  " + assesmentData.Date.Date.ToString();
            gridRow.Cells[1].Style = cellStyle;
            gridRow.Style = cellStyle;

            infoTable.Draw(graphics, new PointF(0, logodim.Y + 30 + sizeF.Height + 30));

            //Description
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);
            PdfTextElement pdfTextElement = new PdfTextElement(statement,font);
            pdfTextElement.Draw(page, new RectangleF(0, logodim.Y + 30 + sizeF.Height + 30 + 100, page.GetClientSize().Width, page.GetClientSize().Height));

        }

        private void addDesignFactorPage(string DfName, string DFDescr, DesignFactorDto designFactorDto)
        {
            PdfPage page = _pdfDocument.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20, PdfFontStyle.Bold);

            SizeF sizeFHeader = font.MeasureString(DfName);

            graphics.DrawString(DfName, font, PdfBrushes.Black, new PointF(0, 0));

            font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);

            SizeF sizeFDescr = font.MeasureString(DFDescr);

            PdfTextElement pdfTextElement = new PdfTextElement(DFDescr, font);
            pdfTextElement.Draw(page, new RectangleF(0, sizeFHeader.Height + 15, page.GetClientSize().Width, page.GetClientSize().Height));

            PdfGrid table = new PdfGrid();

            table.Columns.Add(2);
            table.Headers.Add(1);

            PdfGridRowStyle tableHeaderStyle = new PdfGridRowStyle();

            tableHeaderStyle.BackgroundBrush = PdfBrushes.DarkBlue;
            tableHeaderStyle.TextBrush = PdfBrushes.White;
            tableHeaderStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 15, PdfFontStyle.Bold);

            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;

            PdfGridRow tableHeader = table.Headers[0];
            tableHeader.Style = tableHeaderStyle;

            tableHeader.Cells[0].StringFormat = format;
            tableHeader.Cells[1].StringFormat = format;
            tableHeader.Cells[0].Value = "Question";
            tableHeader.Cells[1].Value = "Assigned Importance value";

            bool col = true;
            foreach (var question in designFactorDto.Questions)
            {
                PdfGridRow tableRow = table.Rows.Add();

                format = new PdfStringFormat();
                format.Alignment = PdfTextAlignment.Center;
                format.LineAlignment = PdfVerticalAlignment.Middle;


                if (col)
                {
                    PdfGridRowStyle dataRowStyle = new PdfGridRowStyle();
                    dataRowStyle.BackgroundBrush = PdfBrushes.AliceBlue;
                    tableRow.Style = dataRowStyle;
                }
                col = !col;

                tableRow.Height = 20;
                tableRow.Cells[0].StringFormat = format;
                tableRow.Cells[1].StringFormat = format;

                tableRow.Cells[0].Value = question.Question;
                tableRow.Cells[1].Value = question.Answers.FirstOrDefault().Answer.ToString();
            }

            table.Draw(page, new PointF(0, sizeFHeader.Height + 20 + sizeFDescr.Height + 50));
        }

        private void addSummary(string heading, string descr, string chartBase64)
        {
            PdfPage page = _pdfDocument.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20, PdfFontStyle.Bold);

            SizeF sizeFHeader = font.MeasureString(heading);

            graphics.DrawString(heading, font, PdfBrushes.DarkBlue, new PointF(0, 0));

            font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);

            SizeF sizeFDescr = font.MeasureString(descr);
            PdfTextElement pdfTextElement = new PdfTextElement(descr, font);
            pdfTextElement.Draw(page, new RectangleF(0, sizeFHeader.Height + 20, page.GetClientSize().Width, page.GetClientSize().Height));

            var bytes = Convert.FromBase64String(chartBase64);
            var contents = new MemoryStream(bytes);

            PdfBitmap pdfBitmap = new PdfBitmap(contents);

            graphics.DrawImage(pdfBitmap, 0, sizeFHeader.Height + 20 + sizeFDescr.Height + 50, page.GetClientSize().Width, 180);
        }
    }
}
