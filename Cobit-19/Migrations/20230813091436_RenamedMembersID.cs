using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class RenamedMembersID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditMembers_ObjectiveAudits_ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers");

            migrationBuilder.RenameColumn(
                name: "ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers",
                newName: "ObjectiveAuditID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAuditMembers_ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers",
                newName: "IX_ObjectiveAuditMembers_ObjectiveAuditID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCompleted",
                table: "ObjectiveAudits",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                keyValue: 1,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 11,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 12,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 13,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 14,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 15,
                column: "DateCompleted",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditMembers_ObjectiveAudits_ObjectiveAuditID",
                table: "ObjectiveAuditMembers",
                column: "ObjectiveAuditID",
                principalTable: "ObjectiveAudits",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectiveAuditMembers_ObjectiveAudits_ObjectiveAuditID",
                table: "ObjectiveAuditMembers");

            migrationBuilder.RenameColumn(
                name: "ObjectiveAuditID",
                table: "ObjectiveAuditMembers",
                newName: "ObjectiveAuditModelID");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectiveAuditMembers_ObjectiveAuditID",
                table: "ObjectiveAuditMembers",
                newName: "IX_ObjectiveAuditMembers_ObjectiveAuditModelID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCompleted",
                table: "ObjectiveAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 11,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 12,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 13,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 14,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 15,
                column: "DateCompleted",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectiveAuditMembers_ObjectiveAudits_ObjectiveAuditModelID",
                table: "ObjectiveAuditMembers",
                column: "ObjectiveAuditModelID",
                principalTable: "ObjectiveAudits",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
