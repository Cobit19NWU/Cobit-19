using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class ObjectiveAuditSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "217b9a7c-13b2-4287-ae3b-10bbc684614c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "c815a3a4-1d44-476e-9cfd-3403422d086c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "245eda66-68ff-456c-b67c-fc06045ebd06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "1feb5893-bb12-4b90-bf3d-b717ec220dad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4fd3774-9ad9-4499-a218-282229970bd0", "AQAAAAEAACcQAAAAEMoNKKQGDNEbpgVj+KyXk3YYQW12k3oEwA2iqgiSGyKxQwcEbOigzIpYv9QnGYfxmQ==", "dc8bd217-eb94-4329-aa52-9690caa633ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285e5fb9-f729-4930-a1ba-1c64ebde4b31", "AQAAAAEAACcQAAAAELWbHQwjnB2E2LbNh4LxeNFFy+Xb6NvhBXRpG4k7SL644Oe7NsR2YL1d8OM2X6vovA==", "1e438525-1cb7-4681-a25d-9d876860e569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c82f3e47-8bcb-4a19-a7fc-da5d43b4c32d", "AQAAAAEAACcQAAAAEI84D4Jl2axyddG/nQ3gVjRr3HAh0ZEK60baAngBs1VIU/Hp+RSJRh1JBEG6gmCfRQ==", "ebea1299-51da-4697-819a-5878a947341a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d25c1f6-8e87-4fc7-a8c3-995e8ac23e49", "AQAAAAEAACcQAAAAEOqN84f0O1wkNMEyEdDQw5dNDcJCrIMqrBMr/I/EQBCr9sOzAUQ//nZCB/D+UMrMbA==", "a6e4cf38-edac-49c2-96e4-5ac5184b72e9" });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 1, 15 });

            migrationBuilder.InsertData(
                table: "ObjectiveAudits",
                columns: new[] { "ID", "ApplicationUserID", "AuditID", "DateCompleted", "DateCreated", "ObjectiveID", "Selected", "Status" },
                values: new object[,]
                {
                    { 16, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, false, 0 },
                    { 17, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, false, 0 },
                    { 18, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, false, 0 },
                    { 19, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, false, 0 },
                    { 20, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, false, 0 },
                    { 21, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, false, 0 },
                    { 22, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, false, 0 },
                    { 23, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, false, 0 },
                    { 24, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, false, 0 },
                    { 25, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, false, 0 },
                    { 26, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, false, 0 },
                    { 27, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, false, 0 },
                    { 28, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, false, 0 },
                    { 29, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, false, 0 },
                    { 30, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, false, 0 },
                    { 31, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, false, 0 },
                    { 32, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, false, 0 },
                    { 33, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, false, 0 },
                    { 34, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, false, 0 },
                    { 35, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, false, 0 },
                    { 36, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, false, 0 },
                    { 37, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, false, 0 },
                    { 38, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, false, 0 },
                    { 39, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, false, 0 },
                    { 40, "8e445865-a24d-4543-a6c6-9443d048cdb9", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, false, 0 },
                    { 41, "8e445865-a24d-4543-a6c6-9443d048cdb9", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 0 },
                    { 42, "8e445865-a24d-4543-a6c6-9443d048cdb9", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, 0 },
                    { 43, "8e445865-a24d-4543-a6c6-9443d048cdb9", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, 0 },
                    { 44, "8e445865-a24d-4543-a6c6-9443d048cdb9", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 0 },
                    { 45, "8e445865-a24d-4543-a6c6-9443d048cdb9", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, 0 },
                    { 46, "8e445865-a24d-4543-a6c6-9443d048cdb9", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, 0 },
                    { 47, "8e445865-a24d-4543-a6c6-9443d048cdb9", 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 0 },
                    { 48, "8e445865-a24d-4543-a6c6-9443d048cdb9", 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, 0 },
                    { 49, "8e445865-a24d-4543-a6c6-9443d048cdb9", 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, 0 },
                    { 50, "8e445865-a24d-4543-a6c6-9443d048cdb9", 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 0 },
                    { 51, "8e445865-a24d-4543-a6c6-9443d048cdb9", 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, 0 },
                    { 52, "8e445865-a24d-4543-a6c6-9443d048cdb9", 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "9aa6de16-88db-423c-b425-f5675f656933");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "81be3be0-4aa1-427d-b79c-004bb8f6065a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "289da533-d076-46d6-97f2-51551aad362d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "f902695a-ee34-430b-bde6-941b432fc89d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3b4ee7-81d6-4eec-9409-80007342b802", "AQAAAAEAACcQAAAAEAqAk68g8f20gW5JDVOMfvhnonTtv2dn5X8ktFOk6gS01wbXbi2rwCYf4pwLixa9zQ==", "2dc2a726-d7d6-4570-ad77-745add65ea1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54e11b6b-3f8f-4e75-814a-49187a6df89d", "AQAAAAEAACcQAAAAEAQKu/kzUALdbulm6RoaP33RRg8m2Spn34cYUpAvtnT2FppSyreccAi8lfqQB9GnSg==", "bf4c5834-7bf6-4116-b4d3-9730bbfb7589" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5ee6120-4749-4b4a-aa3e-1aa0e6923c6c", "AQAAAAEAACcQAAAAELj/PPwYv6G1HqFn0q9ZUVQAOG7lto0/if9VtC29Zbb6lev9/Ka5PZywtJo0oskoxA==", "7ce6da75-825d-4044-9ba4-0f17cc70f830" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b827f58c-ef6f-4016-9e4c-41c90c49a8ac", "AQAAAAEAACcQAAAAEAgpSFh5bdg6Kr/M9B/M+E8BRlMt8Gk2zYsanhRWbte/wbEgd9nvErK6J41PwhrVXw==", "d29a6931-eb3a-4507-9e25-3e64166b1e25" });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AuditID", "ObjectiveID" },
                values: new object[] { 5, 3 });
        }
    }
}
