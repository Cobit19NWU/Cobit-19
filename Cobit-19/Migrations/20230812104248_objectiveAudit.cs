using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class objectiveAudit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditScopes");

            migrationBuilder.CreateTable(
                name: "ObjectiveAuditModels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditID = table.Column<int>(type: "int", nullable: false),
                    ObjectiveID = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Selected = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectiveAuditModels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ObjectiveAuditModels_AspNetUsers_ApplicationUserID",
                        column: x => x.ApplicationUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjectiveAuditModels_Audits_AuditID",
                        column: x => x.AuditID,
                        principalTable: "Audits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectiveAuditModels_Objectives_ObjectiveID",
                        column: x => x.ObjectiveID,
                        principalTable: "Objectives",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObjectiveAuditTemplateModels",
                columns: table => new
                {
                    ObjectiveID = table.Column<int>(type: "int", nullable: false),
                    FocusAreaID = table.Column<int>(type: "int", nullable: false),
                    AuditObject = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectiveAuditTemplateModels", x => new { x.ObjectiveID, x.FocusAreaID });
                    table.ForeignKey(
                        name: "FK_ObjectiveAuditTemplateModels_FocusAreas_FocusAreaID",
                        column: x => x.FocusAreaID,
                        principalTable: "FocusAreas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectiveAuditTemplateModels_Objectives_ObjectiveID",
                        column: x => x.ObjectiveID,
                        principalTable: "Objectives",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ObjectiveAuditModels_AuditID",
                table: "ObjectiveAuditModels",
                column: "AuditID");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectiveAuditModels_ObjectiveID",
                table: "ObjectiveAuditModels",
                column: "ObjectiveID");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectiveAuditTemplateModels_FocusAreaID",
                table: "ObjectiveAuditTemplateModels",
                column: "FocusAreaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObjectiveAuditModels");

            migrationBuilder.DropTable(
                name: "ObjectiveAuditTemplateModels");

            migrationBuilder.CreateTable(
                name: "AuditScopes",
                columns: table => new
                {
                    AuditID = table.Column<int>(type: "int", nullable: false),
                    ObjectiveID = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditScopes", x => new { x.AuditID, x.ObjectiveID });
                    table.ForeignKey(
                        name: "FK_AuditScopes_AspNetUsers_ApplicationUserID",
                        column: x => x.ApplicationUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditScopes_Audits_AuditID",
                        column: x => x.AuditID,
                        principalTable: "Audits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditScopes_Objectives_ObjectiveID",
                        column: x => x.ObjectiveID,
                        principalTable: "Objectives",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3c6719ac-9e4a-4bac-9e67-ca1b65e3da38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "103f0eef-17f7-4e87-bbb2-fd86619314a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "acf8ea35-ca8c-4373-a9c0-cb8b2cf68c43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "7e141700-c5cb-4405-9a6d-729b94e287de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdbf6c62-38ad-4019-a4b5-75ca133cf343", "AQAAAAEAACcQAAAAEPMHtWoyN8TY3rOYB3Y2KTbmJe8egce48V/qi4Yf/RIIP+GWQEpKrMvtaFWoMj6+1w==", "518d1a9d-a247-4a4e-a48b-05a77fe21417" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d082ecad-9593-4ef8-be9b-70094124d366", "AQAAAAEAACcQAAAAELWsIZPlo8Qtrz16m+TZc2CWsyCIG/KBvG9XgTdnBDih3VEyXzQcJcoIINuCxGT76Q==", "da13443c-35c1-4845-b4b2-b17b456855bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56970834-829b-4c05-ae15-a512e9c1c53d", "AQAAAAEAACcQAAAAEFej4BwpoVKA0QcLT5llFZSHtzu7gcAlSSitHfjFKD/HTpaJAsAii9RlHe5jDLrgvA==", "06bfccd2-a649-470d-a485-fc03aba1660a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88cd2cf5-ebb2-415e-b398-39ebc5db2f00", "AQAAAAEAACcQAAAAENQUqeZ8l03uQ/yK65Etn5zw5P7Y4DQQM/DP6eqyuiqCCFhlXq0RRrfZQRtCqAgZrw==", "3f5ac335-7d9b-46fb-b8b0-25b66c664389" });

            migrationBuilder.InsertData(
                table: "AuditScopes",
                columns: new[] { "AuditID", "ObjectiveID", "ApplicationUserID" },
                values: new object[,]
                {
                    { 1, 1, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 1, 2, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 1, 3, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 2, 1, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 2, 2, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 2, 3, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 3, 1, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 3, 2, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 3, 3, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 4, 1, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 4, 2, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 4, 3, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 5, 1, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 5, 2, "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 5, 3, "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditScopes_ApplicationUserID",
                table: "AuditScopes",
                column: "ApplicationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditScopes_ObjectiveID",
                table: "AuditScopes",
                column: "ObjectiveID");
        }
    }
}
