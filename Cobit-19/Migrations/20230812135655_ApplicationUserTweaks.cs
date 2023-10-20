using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserTweaks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAudit_Audits_AuditID",
                table: "ObjectiveAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAudit_Objectives_ObjectiveID",
                table: "ObjectiveAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditMembers_ObjectiveAudit_ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditTemplate_FocusAreas_FocusAreaID",
                table: "ObjectiveAuditTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditTemplate_Objectives_ObjectiveID",
                table: "ObjectiveAuditTemplate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveAuditTemplate",
                table: "ObjectiveAuditTemplate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveAudit",
                table: "ObjectiveAudit");

            migrationBuilder.RenameTable(
                name: "ObjectiveAuditTemplate",
                newName: "ObjectiveAuditTemplates");

            migrationBuilder.RenameTable(
                name: "ObjectiveAudit",
                newName: "ObjectiveAudits");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAuditTemplate_FocusAreaID",
                table: "ObjectiveAuditTemplates",
                newName: "IX_ObjectiveAuditTemplates_FocusAreaID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAudit_ObjectiveID",
                table: "ObjectiveAudits",
                newName: "IX_ObjectiveAudits_ObjectiveID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAudit_AuditID",
                table: "ObjectiveAudits",
                newName: "IX_ObjectiveAudits_AuditID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveAuditTemplates",
                table: "ObjectiveAuditTemplates",
                columns: new[] { "ObjectiveID", "FocusAreaID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveAudits",
                table: "ObjectiveAudits",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "0af85f0c-1a3d-40ce-baf9-ce59fa4449a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "0602b715-0548-46f8-9976-1e8513b900af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "5c4c87ee-b233-42af-aa16-075734ea9ace");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "7b20fee6-3978-45f1-8bdb-20fb35e57e4c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5878011-d39d-4255-9472-863b9d1164cb", "AQAAAAEAACcQAAAAENQreQVTSASHv88M21f/ziBcoGHfpstenGGQ40VO+w6NM6JvxtlXvtPqVboFQ/qW9w==", "a74b79ee-229a-4b74-b8c9-7b523226389a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82569fe8-a128-421c-b5d3-0b37b3dbf10a", "AQAAAAEAACcQAAAAEFowLZ+9uECvgb3vSrCkn57i5HSiXPUyAPm210BUX6yb5YeKXdpRiBzHf/LSr4XwYw==", "9d7204d3-c7e3-4db8-896a-ff3fec47ebfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90531135-49ba-43f5-af57-d5f46401d8e7", "AQAAAAEAACcQAAAAEIzwlYYodfVnUBWZPGGbsmdxzMsir9QCN6dErgGCSV+CH0m4E8GeV6F8VeLpfaHI/Q==", "9b92082f-35ab-4571-aa4e-3ab21184106f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2b3d0f-dd9e-4ae5-8d52-4aac936128e2", "AQAAAAEAACcQAAAAEDwqJxLd2slEzkBfMdlUuExsEKCC0nI9zzYM1lVeGi1V0PUK7txicxcG3TEyMOih7Q==", "f6f785b6-f3c9-4412-8e28-b49320199bf9" });

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditMembers_ObjectiveAudits_ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers",
                column: "ObjectiveAuditModelID",
                principalTable: "ObjectiveAudits",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAudits_Audits_AuditID",
                table: "ObjectiveAudits",
                column: "AuditID",
                principalTable: "Audits",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAudits_Objectives_ObjectiveID",
                table: "ObjectiveAudits",
                column: "ObjectiveID",
                principalTable: "Objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditTemplates_FocusAreas_FocusAreaID",
                table: "ObjectiveAuditTemplates",
                column: "FocusAreaID",
                principalTable: "FocusAreas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditTemplates_Objectives_ObjectiveID",
                table: "ObjectiveAuditTemplates",
                column: "ObjectiveID",
                principalTable: "Objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditMembers_ObjectiveAudits_ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAudits_Audits_AuditID",
                table: "ObjectiveAudits");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAudits_Objectives_ObjectiveID",
                table: "ObjectiveAudits");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditTemplates_FocusAreas_FocusAreaID",
                table: "ObjectiveAuditTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditTemplates_Objectives_ObjectiveID",
                table: "ObjectiveAuditTemplates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveAuditTemplates",
                table: "ObjectiveAuditTemplates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveAudits",
                table: "ObjectiveAudits");

            migrationBuilder.RenameTable(
                name: "ObjectiveAuditTemplates",
                newName: "ObjectiveAuditTemplate");

            migrationBuilder.RenameTable(
                name: "ObjectiveAudits",
                newName: "ObjectiveAudit");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAuditTemplates_FocusAreaID",
                table: "ObjectiveAuditTemplate",
                newName: "IX_ObjectiveAuditTemplate_FocusAreaID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAudits_ObjectiveID",
                table: "ObjectiveAudit",
                newName: "IX_ObjectiveAudit_ObjectiveID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAudits_AuditID",
                table: "ObjectiveAudit",
                newName: "IX_ObjectiveAudit_AuditID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveAuditTemplate",
                table: "ObjectiveAuditTemplate",
                columns: new[] { "ObjectiveID", "FocusAreaID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveAudit",
                table: "ObjectiveAudit",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "24c41893-643c-454e-a3f8-4a1aebf0dc26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "bfe96a89-eb34-4afe-9485-ce5c0add651c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "3b59abd4-c8ca-460f-abb4-570d38ea5b6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "0c082fb7-28b3-4789-a059-f5591476a4af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1dcd348-0a51-4e01-a8ba-d7febfd46096", "AQAAAAEAACcQAAAAEIo0Inmpupvh111js3st/yOBzIlqwzy03IOWi7sIcNBEtr6REfwyMTYzsh/Zw2zXIw==", "8a26c280-cb2b-48ba-b7e2-2e82ee15b04f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c27322aa-80e2-48a4-8d46-5703745ff7b3", "AQAAAAEAACcQAAAAEIJpVGiufjjuRlTL4uHzaN7Oe5BX5fncu95YxQIKcs23KD6sio2+EKH09OjqakFGcA==", "707e791f-eb4e-456f-810d-db0dee0e1cfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e3d7f0d-d735-41f2-9a18-018df61863a7", "AQAAAAEAACcQAAAAEAHACV4QrHkAXghJcaqZAGFpXwBapv0QAskYf/nt/xNVp0ItTB4WI4UjonHDWfRWhg==", "9590b113-2de1-408a-9cb0-8b85083e49fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d3f9eea-e8f0-4595-9bc3-e0a9fb97f437", "AQAAAAEAACcQAAAAEMhQfKkf81WEwE2UY8Fq+x0rQMwI1xEG+Jj17vtIzV5DYlr6Qp8ZBnAnDg4P04CIoQ==", "1256a888-7e44-4c40-9949-318693e5b838" });

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAudit_Audits_AuditID",
                table: "ObjectiveAudit",
                column: "AuditID",
                principalTable: "Audits",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAudit_Objectives_ObjectiveID",
                table: "ObjectiveAudit",
                column: "ObjectiveID",
                principalTable: "Objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditMembers_ObjectiveAudit_ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers",
                column: "ObjectiveAuditModelID",
                principalTable: "ObjectiveAudit",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditTemplate_FocusAreas_FocusAreaID",
                table: "ObjectiveAuditTemplate",
                column: "FocusAreaID",
                principalTable: "FocusAreas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditTemplate_Objectives_ObjectiveID",
                table: "ObjectiveAuditTemplate",
                column: "ObjectiveID",
                principalTable: "Objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
