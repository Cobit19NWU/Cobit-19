using Cobit_19.Shared.Dtos;
using Microsoft.IdentityModel.Tokens;
using Syncfusion.Blazor.CircularGauge.Internal;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using static Cobit_19.Business.Reports.ObjectiveAuditData;

namespace Cobit_19.Business.Reports
{
    public class ObjectiveAuditReport
    {
        private PdfDocument _pdfDocument;

        public ObjectiveAuditReport()
        {
            _pdfDocument = new PdfDocument();
            _pdfDocument.PageSettings.Size = PdfPageSize.A4;
            _pdfDocument.PageSettings.Orientation = PdfPageOrientation.Landscape;
        }

        public MemoryStream create(FullObjectiveAuditDto fullObjectiveAuditDto, AssesmentData data)
        {

            string title = "Maturity Assessment Report for " + fullObjectiveAuditDto.objectiveName;
            addCoverPager(title, fullObjectiveAuditDto.objectiveDescription, fullObjectiveAuditDto.objectivePurpose, data);

            if(fullObjectiveAuditDto.components != null && fullObjectiveAuditDto.components.Count != 0)
            {
                var processes = fullObjectiveAuditDto.components.Where(a => a.componentDescription == "Process").FirstOrDefault();
                if (processes != null)
                {
                    addProcessPage(processes);
                }
            }

            MemoryStream stream = new MemoryStream();

            _pdfDocument.Save(stream);
            _pdfDocument.Close();

            return stream;

        }

        private void addCoverPager(string header, string description, string purpose, AssesmentData assesmentData)
        {
            _pdfDocument.PageSettings.Orientation = PdfPageOrientation.Portrait;
            PdfPage page = _pdfDocument.Pages.Add();

            //LOGO
            var logodim = new PointF(500, 280);
            PdfGraphics graphics = page.Graphics;
            string path = Directory.GetCurrentDirectory();
            FileStream imageStream = new FileStream(path + "/wwwroot/images/CobitWatermark.jpg", FileMode.Open, FileAccess.Read);
            PdfImage logo = new PdfBitmap(imageStream);
            graphics.DrawImage(logo, 0, 0, logodim.X, logodim.Y);

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
            gridRow.Cells[0].Value = "Auditors: " + assesmentData.Auditors.Last();
            gridRow.Cells[0].Style = cellStyle;
            gridRow.Cells[1].Value = "Audit Name:    " + assesmentData.AuditName;
            gridRow.Cells[1].Style = cellStyle;
            gridRow.Style = cellStyle;


            gridRow = infoTable.Rows.Add();
            gridRow.Height = 25;
            gridRow.Cells[0].Value = "Target Level: " + assesmentData.Target;
            gridRow.Cells[0].Style = cellStyle;
            gridRow.Cells[1].Value = "Year:    " + assesmentData.Date.Year;
            gridRow.Cells[1].Style = cellStyle;
            gridRow.Style = cellStyle;

            gridRow = infoTable.Rows.Add();
            gridRow.Height = 25;
            gridRow.Cells[0].Value = "Maturity Level:" + assesmentData.Maturity.ToString();
            gridRow.Cells[0].Style = cellStyle;
            gridRow.Cells[1].Value = "";
            gridRow.Cells[1].Style = cellStyle;
            gridRow.Style = cellStyle;


            infoTable.Draw(graphics, new PointF(0, logodim.Y + 30 + sizeF.Height + 30));

            // Description Header
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold);
            graphics.DrawString("Description", font, PdfBrushes.Black, new PointF(0, logodim.Y + 30 + sizeF.Height + 30 + 130));
            //Description
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);
            PdfTextElement pdfTextElement = new PdfTextElement(description, font);
            pdfTextElement.Draw(page, new RectangleF(0, logodim.Y + 30 + sizeF.Height + 30 + 150, page.GetClientSize().Width, page.GetClientSize().Height));

            // Description Header
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold);
            graphics.DrawString("Purpose", font, PdfBrushes.Black, new PointF(0, logodim.Y + 30 + sizeF.Height + 30 + 195));
            //Purpose
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);
            pdfTextElement = new PdfTextElement(purpose, font);
            pdfTextElement.Draw(page, new RectangleF(0, logodim.Y + 30 + sizeF.Height + 30 + 215, page.GetClientSize().Width, page.GetClientSize().Height));

            // Process Description
            string processHeader = "Process compliance";
            string ProcessDescription = "Processes describe an organized set of practices and activities to achieve certain objectives and produce a set of outputs that support achievement of overall IT-related goals.";

            font = new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold);
            graphics.DrawString(processHeader, font, PdfBrushes.Black, new PointF(0, logodim.Y + 30 + sizeF.Height + 30 + 290));

            font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);
            pdfTextElement = new PdfTextElement(ProcessDescription, font);
            pdfTextElement.Draw(page, new RectangleF(0, logodim.Y + 30 + sizeF.Height + 30 +310, page.GetClientSize().Width, page.GetClientSize().Height));

        }

        private void addProcessPage(ComponentDto component)
        {
            foreach(SubComponentDto subComponentDto in component.subComponents)
            {
                var title = subComponentDto.subComponentCode + " - " + subComponentDto.subComponentName;
                subProcess(title, subComponentDto.subComponentQuestions);
            }
        }

        public string GetAnswerAchievement(double answerValue)
        {
            if (answerValue <= 2)
            {
                return "Not Achieved";
            }
            else if (answerValue > 2 && answerValue <= 5)
            {
                return "Partially Achieved";
            }
            else if (answerValue > 5 && answerValue <= 8)
            {
                return "Largely Achieved";
            }
            else
            {
                return "Fully Achieved";
            }
        }

        private void subProcess(string header, List<SubComponentQuestionDto> questions)
        {
            PdfPage page = _pdfDocument.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20, PdfFontStyle.Bold);

            SizeF sizeFHeader = font.MeasureString(header);
            graphics.DrawString(header, font, PdfBrushes.Black, new PointF(0, 0));

            PdfGrid table = new PdfGrid();

            table.Columns.Add(5);
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
            tableHeader.Cells[2].StringFormat = format;
            tableHeader.Cells[3].StringFormat = format;
            tableHeader.Cells[4].StringFormat = format;
            tableHeader.Cells[0].Value = "Maturity Level";
            tableHeader.Cells[1].Value = "Activity";
            tableHeader.Cells[2].Value = "Importance";
            tableHeader.Cells[3].Value = "Rating";
            tableHeader.Cells[3].Value = "Comment";

            bool col = true;
            foreach (var question in questions)
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

                tableRow.Cells[0].StringFormat = format;
                tableRow.Cells[1].StringFormat = format;
                tableRow.Cells[2].StringFormat = format;
                tableRow.Cells[3].StringFormat = format;
                tableRow.Cells[4].StringFormat = format;

                if (!question.questionDescription.IsNullOrEmpty())
                {
                    tableRow.Cells[0].Value = question.questionType;
                    tableRow.Cells[1].Value = question.questionDescription;
                    tableRow.Cells[2].Value = question.questionAnswer.ToString();
                    tableRow.Cells[3].Value = GetAnswerAchievement(question.questionScore);
                    tableRow.Cells[4].Value = question.questionComment.ToString();
                }
            }

            table.Draw(page, new PointF(0, sizeFHeader.Height + 20));
        }


    }
}
