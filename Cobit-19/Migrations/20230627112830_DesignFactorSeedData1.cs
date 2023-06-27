using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DesignFactorSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DefaultAnswer", "Question" },
                values: new object[] { 3, "Growth/Acquisition" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DefaultAnswer", "Question" },
                values: new object[] { 3, "Innovation/Differentiation" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DefaultAnswer", "Question" },
                values: new object[] { 3, "Cost Leadership" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "ID", "DefaultAnswer", "DesignFactorID", "Question" },
                values: new object[,]
                {
                    { 4, 3, 1, "Client Service/Stability" },
                    { 5, 3, 2, "EG01—Portfolio of competitive products and services" },
                    { 6, 3, 2, "EG02—Managed business risk" },
                    { 7, 3, 2, "EG03—Compliance with external laws and regulations" },
                    { 8, 3, 2, "EG04—Quality of financial information" },
                    { 9, 3, 2, "EG05—Customer-oriented service culture" },
                    { 10, 3, 2, "EG06—Business-service continuity and availability" },
                    { 11, 3, 2, "EG07—Quality of management information" },
                    { 12, 3, 2, "EG08—Optimization of internal business process functionality" },
                    { 13, 3, 2, "EG09—Optimization of business process costs" },
                    { 14, 3, 2, "EG10—Staff skills, motivation and productivity" },
                    { 15, 3, 2, "EG11—Compliance with internal policies" },
                    { 16, 3, 2, "EG12—Managed digital transformation programs" },
                    { 17, 3, 2, "EG13—Product and business innovation" },
                    { 18, 9, 3, "IT investment decision-making, portfolio definition & maintenance" },
                    { 19, 9, 3, "Program & projects life cycle management" },
                    { 20, 9, 3, "IT cost & oversight" },
                    { 21, 9, 3, "IT expertise, skills & behaviour" },
                    { 22, 9, 3, "Enterprise/IT architecture" },
                    { 23, 9, 3, "IT operational infrastructure incidents" },
                    { 24, 9, 3, "Unauthorized actions" },
                    { 25, 9, 3, "Software adoption/usage problems" },
                    { 26, 9, 3, "Hardware incidents" },
                    { 27, 9, 3, "Software failures" },
                    { 28, 9, 3, "Logical attacks (hacking, malware, etc.)" },
                    { 29, 9, 3, "Third-party/supplier incidents" },
                    { 30, 9, 3, "Noncompliance" },
                    { 31, 9, 3, "Geopolitical Issues" },
                    { 32, 9, 3, "Industrial action" },
                    { 33, 9, 3, "Acts of nature" },
                    { 34, 9, 3, "Technology-based innovation" },
                    { 35, 9, 3, "Environmental" },
                    { 36, 9, 3, "Data & information management" },
                    { 37, 1, 4, "Frustration between different IT entities across the organization because of a perception of low contribution to business value" },
                    { 38, 1, 4, "Frustration between business departments (i.e., the IT customer) and the IT department because of failed initiatives or a perception of low contribution to business value" },
                    { 39, 1, 4, "Significant IT-related incidents, such as data loss, security breaches, project failure and application errors, linked to IT" },
                    { 40, 1, 4, "Service delivery problems by the IT outsourcer(s)" },
                    { 41, 1, 4, "Failures to meet IT-related regulatory or contractual requirements" },
                    { 42, 1, 4, "Regular audit findings or other assessment reports about poor IT performance or reported IT quality or service problems" },
                    { 43, 1, 4, "Substantial hidden and rogue IT spending, that is, IT spending by user departments outside the control of the normal IT investment decision mechanisms and approved budgets" },
                    { 44, 1, 4, "Duplications or overlaps between various initiatives, or other forms of wasted resources" },
                    { 45, 1, 4, "Insufficient IT resources, staff with inadequate skills or staff burnout/dissatisfaction" },
                    { 46, 1, 4, "IT-enabled changes or projects frequently failing to meet business needs and delivered late or over budget" },
                    { 47, 1, 4, "Reluctance by board members, executives or senior management to engage with IT, or a lack of committed business sponsorship for IT" },
                    { 48, 1, 4, "Complex IT operating model and/or unclear decision mechanisms for IT-related decisions" },
                    { 49, 1, 4, "Excessively high cost of IT" },
                    { 50, 2, 4, "Obstructed or failed implementation of new initiatives or innovations caused by the current IT architecture and systems" },
                    { 51, 2, 4, "Gap between business and technical knowledge, which leads to business users and information and/or technology specialists speaking different languages" },
                    { 52, 2, 4, "Regular issues with data quality and integration of data across various sources" },
                    { 53, 2, 4, "High level of end-user computing, creating (among other problems) a lack of oversight and quality control over the applications that are being developed and put in operation" },
                    { 54, 2, 4, "Business departments implementing their own information solutions with little or no involvement of the enterprise IT department (related to end-user computing, which often stems from dissatisfaction with IT solutions and services)" },
                    { 55, 2, 4, "Ignorance of and/or noncompliance with privacy regulations" },
                    { 56, 2, 4, "Inability to exploit new technologies or innovate using I&T" },
                    { 57, 33, 5, "High" },
                    { 58, 67, 5, "Normal" },
                    { 59, 0, 6, "High compliance requirements" },
                    { 60, 100, 6, "Normal compliance requirements" },
                    { 61, 0, 6, "Low compliance requirements" },
                    { 62, 3, 7, "Support" },
                    { 63, 3, 7, "Factory" },
                    { 64, 3, 7, "Turnaround" },
                    { 65, 3, 7, "Strategic" },
                    { 66, 33, 8, "Outsourcing" },
                    { 67, 33, 8, "Cloud" },
                    { 68, 34, 8, "Insourced" },
                    { 69, 15, 9, "Agile" },
                    { 70, 10, 9, "DevOps" },
                    { 71, 75, 9, "Traditional" },
                    { 72, 15, 10, "First mover" },
                    { 73, 70, 10, "Follower" },
                    { 74, 15, 10, "Slow adopter" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DefaultAnswer", "Question" },
                values: new object[] { 1, "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DefaultAnswer", "Question" },
                values: new object[] { 1, "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DefaultAnswer", "Question" },
                values: new object[] { 1, "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?" });
        }
    }
}
