using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class ObjectiveAuditMembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditModels_AspNetUsers_ApplicationUserID",
                table: "ObjectiveAuditModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditModels_Audits_AuditID",
                table: "ObjectiveAuditModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditModels_Objectives_ObjectiveID",
                table: "ObjectiveAuditModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditTemplateModels_FocusAreas_FocusAreaID",
                table: "ObjectiveAuditTemplateModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditTemplateModels_Objectives_ObjectiveID",
                table: "ObjectiveAuditTemplateModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveAuditTemplateModels",
                table: "ObjectiveAuditTemplateModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveAuditModels",
                table: "ObjectiveAuditModels");

            migrationBuilder.DropIndex(
                name: "IX_ObjectiveAuditModels_ApplicationUserID",
                table: "ObjectiveAuditModels");

            migrationBuilder.RenameTable(
                name: "ObjectiveAuditTemplateModels",
                newName: "ObjectiveAuditTemplate");

            migrationBuilder.RenameTable(
                name: "ObjectiveAuditModels",
                newName: "ObjectiveAudit");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAuditTemplateModels_FocusAreaID",
                table: "ObjectiveAuditTemplate",
                newName: "IX_ObjectiveAuditTemplate_FocusAreaID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAuditModels_ObjectiveID",
                table: "ObjectiveAudit",
                newName: "IX_ObjectiveAudit_ObjectiveID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAuditModels_AuditID",
                table: "ObjectiveAudit",
                newName: "IX_ObjectiveAudit_AuditID");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "ObjectiveAudit",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveAuditTemplate",
                table: "ObjectiveAuditTemplate",
                columns: new[] { "ObjectiveID", "FocusAreaID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveAudit",
                table: "ObjectiveAudit",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "ObjectiveAuditMembers",
                columns: table => new
                {
                    ObjectiveAuditModelID = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectiveAuditMembers", x => new { x.ApplicationUserID, x.ObjectiveAuditModelID });
                    table.ForeignKey(
                        name: "FK_ObjectiveAuditMembers_AspNetUsers_ApplicationUserID",
                        column: x => x.ApplicationUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjectiveAuditMembers_ObjectiveAudit_ObjectiveAuditModelID",
                        column: x => x.ObjectiveAuditModelID,
                        principalTable: "ObjectiveAudit",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ObjectiveAuditMembers_ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers",
                column: "ObjectiveAuditModelID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAudit_Audits_AuditID",
                table: "ObjectiveAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAudit_Objectives_ObjectiveID",
                table: "ObjectiveAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditTemplate_FocusAreas_FocusAreaID",
                table: "ObjectiveAuditTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditTemplate_Objectives_ObjectiveID",
                table: "ObjectiveAuditTemplate");

            migrationBuilder.DropTable(
                name: "ObjectiveAuditMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveAuditTemplate",
                table: "ObjectiveAuditTemplate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveAudit",
                table: "ObjectiveAudit");

            migrationBuilder.RenameTable(
                name: "ObjectiveAuditTemplate",
                newName: "ObjectiveAuditTemplateModels");

            migrationBuilder.RenameTable(
                name: "ObjectiveAudit",
                newName: "ObjectiveAuditModels");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAuditTemplate_FocusAreaID",
                table: "ObjectiveAuditTemplateModels",
                newName: "IX_ObjectiveAuditTemplateModels_FocusAreaID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAudit_ObjectiveID",
                table: "ObjectiveAuditModels",
                newName: "IX_ObjectiveAuditModels_ObjectiveID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAudit_AuditID",
                table: "ObjectiveAuditModels",
                newName: "IX_ObjectiveAuditModels_AuditID");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "ObjectiveAuditModels",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveAuditTemplateModels",
                table: "ObjectiveAuditTemplateModels",
                columns: new[] { "ObjectiveID", "FocusAreaID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveAuditModels",
                table: "ObjectiveAuditModels",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "8e5408f4-78d3-4aab-b00a-0608df6999cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "3719b2da-175e-44bd-a9ec-3d2a4524a521");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "015d9d19-bdc6-4e20-9674-44f946a16903");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "47c122bb-5b90-4bee-886f-37811f4deda3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87244c04-3eac-4f91-98cd-798937fe2acb", "AQAAAAEAACcQAAAAEEqPUtKnvQZInHxxAYhToDKrjmmPUp/sOP2MKoLbSlk63hYkIX6funBSmukE7TPMuA==", "e9192e98-cdf9-424b-b820-4a67cd95c99d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5ef5f17-1521-4459-816e-f9185cf661d0", "AQAAAAEAACcQAAAAEO7VFoP0l46Cqbsxsi4bg88/ok0HxxLsdoNREt8TQiJvnC9ABUUBsVwvY3VsDZGGDw==", "ab7447ee-95ab-42bf-9368-d08e7f0456b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2a050fb-d163-472b-a1ca-81ba19b59824", "AQAAAAEAACcQAAAAEAkOi2F2P+bW5eUfiZ0ZJVD8r1QlGSm9wkUMpqDQA5p3sE/qfM4Frt5XvpGFNyJc9w==", "743b1aa1-67a4-4838-920d-8c822bb4c69e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b859cfa-502c-4bd9-9b96-99c587b19a21", "AQAAAAEAACcQAAAAEIHmCxG37r4K8XQdVylh+8BDQt/SNHlSAYlApGzZCYrenfHrtADRiU/tXRv4VPQXhA==", "d0f21eb4-2aef-4f81-9869-ef43a2a4792f" });

            migrationBuilder.CreateIndex(
                name: "IX_ObjectiveAuditModels_ApplicationUserID",
                table: "ObjectiveAuditModels",
                column: "ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditModels_AspNetUsers_ApplicationUserID",
                table: "ObjectiveAuditModels",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditModels_Audits_AuditID",
                table: "ObjectiveAuditModels",
                column: "AuditID",
                principalTable: "Audits",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditModels_Objectives_ObjectiveID",
                table: "ObjectiveAuditModels",
                column: "ObjectiveID",
                principalTable: "Objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditTemplateModels_FocusAreas_FocusAreaID",
                table: "ObjectiveAuditTemplateModels",
                column: "FocusAreaID",
                principalTable: "FocusAreas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditTemplateModels_Objectives_ObjectiveID",
                table: "ObjectiveAuditTemplateModels",
                column: "ObjectiveID",
                principalTable: "Objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
