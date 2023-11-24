using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class IncorrectAPOSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "9adc4c4b-24cc-43fd-822f-f9ededede27d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "01841142-a4fd-4da5-a335-282b0a0f3aa2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "55523281-364a-4b49-a78c-8d19def6a64d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "11c7c406-3141-4318-8dca-4bbe66ca8db9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "fea283d8-d8ab-4ba6-9e05-f492600c269c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9831f582-97f2-4d77-8c18-caadd99f6ff0", "AQAAAAEAACcQAAAAEP4jbnc7JBoFg6umcQrer/21+Cln8CifF32xhHbydFu2OTwQg0jape9PcSExDUTBYA==", "c740185c-3044-4b6d-abf5-c0a2c5526b67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c50903-52a7-4843-a07a-cf6e16f07f84", "AQAAAAEAACcQAAAAENy+ulIWUoRYOyT9m9zwM6TVUaQd1gIyJPqKGP9r2SM3zFUNzz0G1dFBj9AqDI68UA==", "221f22c2-6bcf-4828-b973-2a22e46d6ea7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73989681-836b-48f4-96ba-6ee1208cbbb5", "AQAAAAEAACcQAAAAEHu36gPB24U5isoTmqdocZu5qFGvx2SuzqYJpwABQFCSOkLF16szSYeSfFrIR9F8FQ==", "8bf84940-34a2-44a1-b55f-b95c87a2b6cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e8ef63e-82fc-4e5e-b511-a9536fcd2b19", "AQAAAAEAACcQAAAAEP+xzPFWtzFIgVCPwKmVyf7QXtgAiLMpWLgxBmsU2o8tPH8P1KCwaMMw+WPx3sbjjw==", "0267dff6-813d-4e81-a06f-93993b492ffc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b515dca6-3677-429d-bac6-0bfb8a3d149a", "AQAAAAEAACcQAAAAEL0XWVcKHFNao0cVpN1Qfg+vP9F7cCcft/yYk7RsjdJcstnHllokseFrMLrjJ1s6aQ==", "28c88c98-fc3d-4ef9-b7c7-eb16738b621f" });

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 279, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 279, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 270, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 271, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 272, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 273, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 274, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 275, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 276, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 277, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 278, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 23, 10, 42, 41, 279, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditTemplates",
                keyColumns: new[] { "FocusAreaID", "ObjectiveID" },
                keyValues: new object[] { 1, 16 },
                column: "AuditObject",
                value: "{\r\n  \"objectiveName\": \"APO11\",\r\n  \"objectiveDescription\": \"Define and communicate quality requirements in all processes, procedures and related enterprise outcomes. Enable controls, ongoing monitoring and the use of proven practices and standards in continuous improvement and efficiency efforts.\",\r\n  \"objectivePurpose\": \"Ensure consistent delivery of technology solutions and services to meet the quality requirements of the enterprise and satisfy stakeholder needs.\",\r\n  \"typeOfObjective\": \"Management\",\r\n  \"maturityLevel\": 0,\r\n  \"maturityLevel0PercFinal\": 0,\r\n  \"maturityLevel1PercFinal\": 0,\r\n  \"maturityLevel2PercFinal\": 0,\r\n  \"maturityLevel3PercFinal\": 0,\r\n  \"maturityLevel4PercFinal\": 0,\r\n  \"maturityLevel5PercFinal\": 0,\r\n  \"structuresImage\": \"https://i.imgur.com/W0bWH7f.png\",\r\n  \"components\": [\r\n    {\r\n      \"componentCode\": \"EG\",\r\n      \"componentDescription\": \"Enterprise Goals\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"EG01\",\r\n          \"subComponentName\": \"Portfolio of competitive products and services\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that meet or exceed targets in revenues and/or market share\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that meet or exceed customer satisfaction targets\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that provide competitive advantage\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Time to market for new products and services\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG04\",\r\n          \"subComponentName\": \"Quality of financial information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction survey of key stakeholders regarding the transparency, understanding and accuracy of enterprise financial information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Cost of noncompliance with finance-related regulations\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n\r\n        {\r\n          \"subComponentCode\": \"EG07\",\r\n          \"subComponentName\": \"Quality of management information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Degree of board and executive management satisfaction with decision-making information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Number of incidents caused by incorrect business decisions based on inaccurate information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Time to provide information supporting effective business decisions\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Timeliness of management information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG08\",\r\n          \"subComponentName\": \"Optimization of internal business process functionality\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of board and executive management with business process capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of customers with service delivery capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of suppliers with supply chain capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG12\",\r\n          \"subComponentName\": \"Managed digital transformation programs\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Number of programs on time and within budget\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of stakeholders satisfied with program delivery\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of business transformation programs stopped\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of business transformation programs with regular reported status updates\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n\r\n    {\r\n      \"componentCode\": \"AG\",\r\n      \"componentDescription\": \"Alignment Goals\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"AG10\",\r\n          \"subComponentName\": \"Quality of I&T management information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Level of user satisfaction with quality, timeliness and availability of I&T-related management information, taking into account available resources\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Ratio and extent of erroneous business decisions in which erroneous or unavailable I&T-related information was a key factor\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Percentage of information meeting quality criteria\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n\r\n        {\r\n          \"subComponentCode\": \"AG09\",\r\n          \"subComponentName\": \"Delivering programs on time, on budget and meeting requirements and quality standards\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Number of programs/projects on time and within budget\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Number of programs needing significant rework due to quality defects\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Percent of stakeholders satisfied with program/project quality\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n\r\n    },\r\n    {\r\n      \"componentName\": \"A\",\r\n      \"componentDescription\": \"Processes\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"APO11.01\",\r\n          \"subComponentName\": \"Establish a quality management system (QMS).\",\r\n          \"subComponentDescription\": \"Establish and maintain a quality management system (QMS) that provides a standard formal and continuous approach to quality management of information. The QMS should enable technology and business processes to align with business requirements and enterprise quality management.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Ensure that the I&T control framework and the business and IT processes include a standard, formal and continuous approach to quality management that is aligned with enterprise requirements. Within the I&T control framework and the business and IT processes identify quality requirements and criteria (e.g. based on legal requirements and requirements from customers).\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Define roles, tasks, decision rights and responsibilities for quality management in the organizational structure.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Obtain input from management and external and internal stakeholders on the definition of quality requirements and quality management criteria.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Regularly monitor and review the QMS against agreed acceptance criteria. Include feedback from customers, users and management.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 5\",\r\n              \"questionDescription\": \"Respond to discrepancies in review results to continuously improve the QMS.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.1 Plan quality management\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.02  \",\r\n          \"subComponentName\": \"Focus quality management on customers.\",\r\n          \"subComponentDescription\": \"Focus quality management on customers by determining their requirements and ensuring integration in quality management practices.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \" Focus quality management on customers by determining internal and external customer requirements and ensuring alignment of the I&T standards and practices. Define and communicate roles and responsibilities concerning conflict resolution between the user/customer and the IT organization\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Manage the business needs and expectations for each business process, IT operational service and new solutions. Maintain their quality acceptance criteria.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Communicate customer requirements and expectations throughout the business and IT organization.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Periodically obtain customer views on business process and service provisioning and IT solution delivery. Determine the impact on I&T standards and practices and ensure that customer expectations are met and actioned.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Capture quality acceptance criteria for inclusion in SLAs\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Input\",\r\n              \"questionDescription\": \"Business and customer quality requirements\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"Outside COBIT\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Customer requirements for quality management\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO08.05;APO09.03;BAI01.07;BAI11.06\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Results of quality of service including customer feedback\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO08.05;APO09.05;BAI05.01;BAI07.07\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Acceptance criteria\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"BAI02.01;BAI02.02\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.03 \",\r\n          \"subComponentName\": \"Manage quality standards, practices and procedures and integrate quality management into key processes and solutions.\",\r\n          \"subComponentDescription\": \"Identify and maintain standards, procedures and practices for key processes to guide the enterprise in meeting the intent of the agreed quality management standards (QMS). This activity should align with I&T control framework requirements. Consider certification for key processes organizational units products or services.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 2\",\r\n              \"questionDescription\": \"Define the quality management standards, practices and procedures in line with the I&T control framework’s requirements and enterprise quality management criteria and policies.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Integrate the required quality management practices in key processes and solutions across the organization.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Consider the benefits and costs of quality certifications.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \" Effectively communicate the quality management approach (e.g., through regular, formal quality training programs).\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Record and monitor quality data. Use industry good practices for reference when improving and tailoring the enterprise’s quality practices.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Regularly review the continued relevance, efficiency and effectiveness of specific quality management processes. Monitor the achievement of quality objectives.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.2 Manage quality\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.04\",\r\n          \"subComponentName\": \" Perform quality monitoring, control and reviews\",\r\n          \"subComponentDescription\": \"Monitor the quality of processes and services on an ongoing basis in line with quality management standards. Define plan and implement measurements to monitor customer satisfaction with quality as well as the value provide by the quality management system (QMS). The information gathered should be used by the process owner to improve quality.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \". Prepare and conduct quality reviews for key organizational processes and solutions.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"For these key organizational processes and solutions, monitor goal-driven quality metrics aligned to overall quality objectives.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Evaluate performance and provide regular and formal reporting of service agreement performance, including deviations from the agreed values. Distribute this report to business relationship management.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Ensure that management and process owners regularly review quality management performance against defined quality metrics.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Analyze overall quality management performance results.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 5\",\r\n              \"questionDescription\": \"Report the quality management performance review results and initiate improvements where appropriate.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.3 Control quality\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.05\",\r\n          \"subComponentName\": \"Maintain continuous improvement\",\r\n          \"subComponentDescription\": \"Maintain and regularly communicate an overall quality plan that promotes continuous improvement. The plan should define the need for and benefits of continuous improvement. Collect and analyze  data about the quality management system (QMS) and improve its effectiveness. Correct non conformities to prevent recurrence.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 2\",\r\n              \"questionDescription\": \"Establish a platform to share good practices and capture information on defects and mistakes to enable learning from them\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Identify examples of excellent quality delivery processes that can benefit other services or projects. Share these with the service and project deliver teams to encourage improvement.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Identify recurring examples of quality defects. Determine their root cause, evaluate their impact and result, and agree on improvement actions with the service and/or project delivery teams.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Provide employees with training in the methods and tools of continual improvement\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Benchmark the results of the quality reviews against internal historical data, industry guidelines, standards and data from similar types  enterprises.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided., \",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"National Institute of Standards and Technology Framework for Improving Critical Infrastructure Cybersecurity v1.1 April 2018\",\r\n              \"detailedReference\": \"DE.DP Detection Processes\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality review benchmark results\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Examples of good practice to be shared\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Communications on continual improvement and best practices\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"B\",\r\n      \"componentDescription\": \"Organizational Structures\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"APO11.01\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.02 \",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.03 \",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.04\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.05\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentCode\": \"C\",\r\n      \"componentDescription\": \"Information Flows and Items\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"APO11.01\",\r\n          \"subComponentName\": \"Establish a quality management system (QMS).\",\r\n          \"subComponentDescription\": \"Establish and maintain a quality management system (QMS) that provides a standard formal and continuous approach to quality management of information. The QMS should enable technology and business processes to align with business requirements and enterprise quality management.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Input\",\r\n              \"questionDescription\": \"Enterprisewide quality system\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"Outside COBIT\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Results of QMS effectiveness reviews\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"BAI03.06\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality management plans\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO14.04;APO14.06;BAI01.07;BAI11.05\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality management system (QMS) roles responsibilities and decision rights\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO01.05;DSS06.03\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n            {\r\n              \"subComponentCode\": \"APO11.02  \",\r\n              \"subComponentName\": \"Focus quality management on customers.\",\r\n              \"subComponentDescription\": \"Focus quality management on customers by determining their requirements and ensuring integration in quality management practices.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"Business and customer quality requirements\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"Outside COBIT\",\r\n                  \"outputTo\": \"No data provided.,\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Customer requirements for quality management\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.03;BAI01.07;BAI11.06\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality of service including customer feedback\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.05;BAI05.01;BAI07.07\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Acceptance criteria\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"BAI02.01;BAI02.02\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n\r\n              ]\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.03 \",\r\n              \"subComponentName\": \"Manage quality standards, practices and procedures and integrate quality management into key processes and solutions.\",\r\n              \"subComponentDescription\": \"Identify and maintain standards, procedures and practices for key processes to guide the enterprise in meeting the intent of the agreed quality management standards (QMS). This activity should align with I&T control framework requirements. Consider certification for key processes organizational units products or services.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"Approved quality reviews\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"BAI02.04\",\r\n                  \"outputTo\": \"No data provided.,\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Available quality certifications • Industry good practices\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"Outside COBIT\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Quality management standards\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Root causes of quality delivery failures\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.02;APO09.04;BAI07.08;MEA02.04; MEA04.04\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality monitoring\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.04;BAI07.08\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n              ]\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.04\",\r\n              \"subComponentName\": \" Perform quality monitoring, control and reviews\",\r\n              \"subComponentDescription\": \"Monitor the quality of processes and services on an ongoing basis in line with quality management standards. Define plan and implement measurements to monitor customer satisfaction with quality as well as the value provide by the quality management system (QMS). The information gathered should be used by the process owner to improve quality.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Quality assurance plan •Quality review results exceptions and corrections\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputFrom\": \"sring,\",\r\n                  \"inputFrom\": \"BAI03.06\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Incident status and trends report • Status of request fulfilment and trends report\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"DSS02.07\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Process quality of service goals and metrics\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality reviews and audits\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.04; APO09.05;BAI07.08\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n\r\n              ]\r\n\r\n\r\n\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.05\",\r\n              \"subComponentName\": \"Maintain continuous improvement\",\r\n              \"subComponentDescription\": \"Maintain and regularly communicate an overall quality plan that promotes continuous improvement. The plan should define the need for and benefits of continuous improvement. Collect and analyze  data about the quality management system (QMS) and improve its effectiveness. Correct non conformities to prevent recurrence.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Quality review benchmark results\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Examples of good practice to be shared\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Communications on continual improvement and best practices\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n              ]\r\n            }\r\n          ]\r\n        },\r\n    {\r\n      \"componentName\": \"D\",\r\n      \"componentDescription\": \"Peoples, Skills and Competencies\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"ICT quality strategy development\",\r\n          \"relatedGuidance\": \"e-Competence Framework (e-CF)—A common European Framework for ICT Professionals in all industry sectors—Part 1:Framework 2016 \",\r\n          \"detailedReference\": \"D. Enable—D.2. ICT Quality Strategy Development\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUAS\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUMG\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUST\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"E\",\r\n      \"componentDescription\": \"Principles Policies and Procedures\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"relevantPolicy\": \"Quality management policy\",\r\n          \"policyDescription\": \"Captures management’s vision of enterprise quality objectives acceptable level of quality and duties of specific teams and entities to ensure quality.\",\r\n          \"detailedGuidance\": \"No data provided.\",\r\n          \"detailedReference\": \"No data provided.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"F\",\r\n      \"componentDescription\": \"Culture, Ethics and Behavior\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"keyCultureElement\": \"Promote a culture of quality and continual improvement. Maintain, and regularly communicate the need for and benefits of quality and continuous improvement.\",\r\n          \"relatedGuidance\": \"No data provided.\",\r\n          \"detailedReference\": \"No data provided.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"G\",\r\n      \"componentDescription\": \"Services, Infrastructure and Applications\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionDescription\": \" QMS\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionDescription\": \"Third-party quality assurance services\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    }\r\n  ]\r\n}\r\n  ");

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 2,
                column: "UserAuditObject",
                value: "{\r\n  \"objectiveName\": \"APO11\",\r\n  \"objectiveDescription\": \"Define and communicate quality requirements in all processes, procedures and related enterprise outcomes. Enable controls, ongoing monitoring and the use of proven practices and standards in continuous improvement and efficiency efforts.\",\r\n  \"objectivePurpose\": \"Ensure consistent delivery of technology solutions and services to meet the quality requirements of the enterprise and satisfy stakeholder needs.\",\r\n  \"typeOfObjective\": \"Management\",\r\n  \"maturityLevel\": 0,\r\n  \"maturityLevel0PercFinal\": 0,\r\n  \"maturityLevel1PercFinal\": 0,\r\n  \"maturityLevel2PercFinal\": 0,\r\n  \"maturityLevel3PercFinal\": 0,\r\n  \"maturityLevel4PercFinal\": 0,\r\n  \"maturityLevel5PercFinal\": 0,\r\n  \"structuresImage\": \"https://i.imgur.com/W0bWH7f.png\",\r\n  \"components\": [\r\n    {\r\n      \"componentCode\": \"EG\",\r\n      \"componentDescription\": \"Enterprise Goals\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"EG01\",\r\n          \"subComponentName\": \"Portfolio of competitive products and services\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that meet or exceed targets in revenues and/or market share\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that meet or exceed customer satisfaction targets\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that provide competitive advantage\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Time to market for new products and services\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG04\",\r\n          \"subComponentName\": \"Quality of financial information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction survey of key stakeholders regarding the transparency, understanding and accuracy of enterprise financial information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Cost of noncompliance with finance-related regulations\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n\r\n        {\r\n          \"subComponentCode\": \"EG07\",\r\n          \"subComponentName\": \"Quality of management information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Degree of board and executive management satisfaction with decision-making information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Number of incidents caused by incorrect business decisions based on inaccurate information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Time to provide information supporting effective business decisions\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Timeliness of management information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG08\",\r\n          \"subComponentName\": \"Optimization of internal business process functionality\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of board and executive management with business process capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of customers with service delivery capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of suppliers with supply chain capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG12\",\r\n          \"subComponentName\": \"Managed digital transformation programs\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Number of programs on time and within budget\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of stakeholders satisfied with program delivery\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of business transformation programs stopped\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of business transformation programs with regular reported status updates\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n\r\n    {\r\n      \"componentCode\": \"AG\",\r\n      \"componentDescription\": \"Alignment Goals\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"AG10\",\r\n          \"subComponentName\": \"Quality of I&T management information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Level of user satisfaction with quality, timeliness and availability of I&T-related management information, taking into account available resources\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Ratio and extent of erroneous business decisions in which erroneous or unavailable I&T-related information was a key factor\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Percentage of information meeting quality criteria\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n\r\n        {\r\n          \"subComponentCode\": \"AG09\",\r\n          \"subComponentName\": \"Delivering programs on time, on budget and meeting requirements and quality standards\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Number of programs/projects on time and within budget\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Number of programs needing significant rework due to quality defects\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Percent of stakeholders satisfied with program/project quality\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n\r\n    },\r\n    {\r\n      \"componentName\": \"A\",\r\n      \"componentDescription\": \"Processes\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"APO11.01\",\r\n          \"subComponentName\": \"Establish a quality management system (QMS).\",\r\n          \"subComponentDescription\": \"Establish and maintain a quality management system (QMS) that provides a standard formal and continuous approach to quality management of information. The QMS should enable technology and business processes to align with business requirements and enterprise quality management.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Ensure that the I&T control framework and the business and IT processes include a standard, formal and continuous approach to quality management that is aligned with enterprise requirements. Within the I&T control framework and the business and IT processes identify quality requirements and criteria (e.g. based on legal requirements and requirements from customers).\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Define roles, tasks, decision rights and responsibilities for quality management in the organizational structure.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Obtain input from management and external and internal stakeholders on the definition of quality requirements and quality management criteria.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Regularly monitor and review the QMS against agreed acceptance criteria. Include feedback from customers, users and management.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 5\",\r\n              \"questionDescription\": \"Respond to discrepancies in review results to continuously improve the QMS.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.1 Plan quality management\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.02  \",\r\n          \"subComponentName\": \"Focus quality management on customers.\",\r\n          \"subComponentDescription\": \"Focus quality management on customers by determining their requirements and ensuring integration in quality management practices.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \" Focus quality management on customers by determining internal and external customer requirements and ensuring alignment of the I&T standards and practices. Define and communicate roles and responsibilities concerning conflict resolution between the user/customer and the IT organization\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Manage the business needs and expectations for each business process, IT operational service and new solutions. Maintain their quality acceptance criteria.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Communicate customer requirements and expectations throughout the business and IT organization.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Periodically obtain customer views on business process and service provisioning and IT solution delivery. Determine the impact on I&T standards and practices and ensure that customer expectations are met and actioned.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Capture quality acceptance criteria for inclusion in SLAs\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Input\",\r\n              \"questionDescription\": \"Business and customer quality requirements\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"Outside COBIT\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Customer requirements for quality management\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO08.05;APO09.03;BAI01.07;BAI11.06\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Results of quality of service including customer feedback\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO08.05;APO09.05;BAI05.01;BAI07.07\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Acceptance criteria\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"BAI02.01;BAI02.02\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.03 \",\r\n          \"subComponentName\": \"Manage quality standards, practices and procedures and integrate quality management into key processes and solutions.\",\r\n          \"subComponentDescription\": \"Identify and maintain standards, procedures and practices for key processes to guide the enterprise in meeting the intent of the agreed quality management standards (QMS). This activity should align with I&T control framework requirements. Consider certification for key processes organizational units products or services.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 2\",\r\n              \"questionDescription\": \"Define the quality management standards, practices and procedures in line with the I&T control framework’s requirements and enterprise quality management criteria and policies.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Integrate the required quality management practices in key processes and solutions across the organization.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Consider the benefits and costs of quality certifications.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \" Effectively communicate the quality management approach (e.g., through regular, formal quality training programs).\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Record and monitor quality data. Use industry good practices for reference when improving and tailoring the enterprise’s quality practices.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Regularly review the continued relevance, efficiency and effectiveness of specific quality management processes. Monitor the achievement of quality objectives.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.2 Manage quality\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.04\",\r\n          \"subComponentName\": \" Perform quality monitoring, control and reviews\",\r\n          \"subComponentDescription\": \"Monitor the quality of processes and services on an ongoing basis in line with quality management standards. Define plan and implement measurements to monitor customer satisfaction with quality as well as the value provide by the quality management system (QMS). The information gathered should be used by the process owner to improve quality.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \". Prepare and conduct quality reviews for key organizational processes and solutions.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"For these key organizational processes and solutions, monitor goal-driven quality metrics aligned to overall quality objectives.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Evaluate performance and provide regular and formal reporting of service agreement performance, including deviations from the agreed values. Distribute this report to business relationship management.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Ensure that management and process owners regularly review quality management performance against defined quality metrics.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Analyze overall quality management performance results.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 5\",\r\n              \"questionDescription\": \"Report the quality management performance review results and initiate improvements where appropriate.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.3 Control quality\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.05\",\r\n          \"subComponentName\": \"Maintain continuous improvement\",\r\n          \"subComponentDescription\": \"Maintain and regularly communicate an overall quality plan that promotes continuous improvement. The plan should define the need for and benefits of continuous improvement. Collect and analyze  data about the quality management system (QMS) and improve its effectiveness. Correct non conformities to prevent recurrence.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 2\",\r\n              \"questionDescription\": \"Establish a platform to share good practices and capture information on defects and mistakes to enable learning from them\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Identify examples of excellent quality delivery processes that can benefit other services or projects. Share these with the service and project deliver teams to encourage improvement.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Identify recurring examples of quality defects. Determine their root cause, evaluate their impact and result, and agree on improvement actions with the service and/or project delivery teams.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Provide employees with training in the methods and tools of continual improvement\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Benchmark the results of the quality reviews against internal historical data, industry guidelines, standards and data from similar types  enterprises.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided., \",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"National Institute of Standards and Technology Framework for Improving Critical Infrastructure Cybersecurity v1.1 April 2018\",\r\n              \"detailedReference\": \"DE.DP Detection Processes\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality review benchmark results\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Examples of good practice to be shared\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Communications on continual improvement and best practices\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"B\",\r\n      \"componentDescription\": \"Organizational Structures\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"APO11.01\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.02 \",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.03 \",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.04\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.05\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentCode\": \"C\",\r\n      \"componentDescription\": \"Information Flows and Items\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"APO11.01\",\r\n          \"subComponentName\": \"Establish a quality management system (QMS).\",\r\n          \"subComponentDescription\": \"Establish and maintain a quality management system (QMS) that provides a standard formal and continuous approach to quality management of information. The QMS should enable technology and business processes to align with business requirements and enterprise quality management.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Input\",\r\n              \"questionDescription\": \"Enterprisewide quality system\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"Outside COBIT\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Results of QMS effectiveness reviews\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"BAI03.06\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality management plans\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO14.04;APO14.06;BAI01.07;BAI11.05\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality management system (QMS) roles responsibilities and decision rights\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO01.05;DSS06.03\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n            {\r\n              \"subComponentCode\": \"APO11.02  \",\r\n              \"subComponentName\": \"Focus quality management on customers.\",\r\n              \"subComponentDescription\": \"Focus quality management on customers by determining their requirements and ensuring integration in quality management practices.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"Business and customer quality requirements\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"Outside COBIT\",\r\n                  \"outputTo\": \"No data provided.,\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Customer requirements for quality management\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.03;BAI01.07;BAI11.06\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality of service including customer feedback\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.05;BAI05.01;BAI07.07\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Acceptance criteria\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"BAI02.01;BAI02.02\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n\r\n              ]\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.03 \",\r\n              \"subComponentName\": \"Manage quality standards, practices and procedures and integrate quality management into key processes and solutions.\",\r\n              \"subComponentDescription\": \"Identify and maintain standards, procedures and practices for key processes to guide the enterprise in meeting the intent of the agreed quality management standards (QMS). This activity should align with I&T control framework requirements. Consider certification for key processes organizational units products or services.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"Approved quality reviews\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"BAI02.04\",\r\n                  \"outputTo\": \"No data provided.,\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Available quality certifications • Industry good practices\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"Outside COBIT\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Quality management standards\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Root causes of quality delivery failures\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.02;APO09.04;BAI07.08;MEA02.04; MEA04.04\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality monitoring\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.04;BAI07.08\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n              ]\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.04\",\r\n              \"subComponentName\": \" Perform quality monitoring, control and reviews\",\r\n              \"subComponentDescription\": \"Monitor the quality of processes and services on an ongoing basis in line with quality management standards. Define plan and implement measurements to monitor customer satisfaction with quality as well as the value provide by the quality management system (QMS). The information gathered should be used by the process owner to improve quality.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Quality assurance plan •Quality review results exceptions and corrections\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputFrom\": \"sring,\",\r\n                  \"inputFrom\": \"BAI03.06\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Incident status and trends report • Status of request fulfilment and trends report\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"DSS02.07\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Process quality of service goals and metrics\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality reviews and audits\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.04; APO09.05;BAI07.08\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n\r\n              ]\r\n\r\n\r\n\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.05\",\r\n              \"subComponentName\": \"Maintain continuous improvement\",\r\n              \"subComponentDescription\": \"Maintain and regularly communicate an overall quality plan that promotes continuous improvement. The plan should define the need for and benefits of continuous improvement. Collect and analyze  data about the quality management system (QMS) and improve its effectiveness. Correct non conformities to prevent recurrence.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Quality review benchmark results\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Examples of good practice to be shared\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Communications on continual improvement and best practices\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n              ]\r\n            }\r\n          ]\r\n        },\r\n    {\r\n      \"componentName\": \"D\",\r\n      \"componentDescription\": \"Peoples, Skills and Competencies\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"ICT quality strategy development\",\r\n          \"relatedGuidance\": \"e-Competence Framework (e-CF)—A common European Framework for ICT Professionals in all industry sectors—Part 1:Framework 2016 \",\r\n          \"detailedReference\": \"D. Enable—D.2. ICT Quality Strategy Development\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUAS\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUMG\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUST\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"E\",\r\n      \"componentDescription\": \"Principles Policies and Procedures\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"relevantPolicy\": \"Quality management policy\",\r\n          \"policyDescription\": \"Captures management’s vision of enterprise quality objectives acceptable level of quality and duties of specific teams and entities to ensure quality.\",\r\n          \"detailedGuidance\": \"No data provided.\",\r\n          \"detailedReference\": \"No data provided.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"F\",\r\n      \"componentDescription\": \"Culture, Ethics and Behavior\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"keyCultureElement\": \"Promote a culture of quality and continual improvement. Maintain, and regularly communicate the need for and benefits of quality and continuous improvement.\",\r\n          \"relatedGuidance\": \"No data provided.\",\r\n          \"detailedReference\": \"No data provided.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"G\",\r\n      \"componentDescription\": \"Services, Infrastructure and Applications\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionDescription\": \" QMS\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionDescription\": \"Third-party quality assurance services\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    }\r\n  ]\r\n}\r\n  ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "5077b50f-e70e-44c1-9cd8-8dd82cd1568d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "3d7cbbaa-adbd-428d-8bfb-acba0fe890dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "dd5c0ecc-5e37-4c20-a9e7-285ae2d83f0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "602ba412-968a-43da-8235-6dbe34187a7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "34164611-1912-4a17-b08c-ab36eb16bb62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f1f0a56-1e68-40ac-ba5f-b3a0a246a21e", "AQAAAAEAACcQAAAAEDFJqKBmdxlnncIMkSqHGTM3UyxF6DeW5AM2MPjz++uNUH0PU6JtATEE4P24igH+vQ==", "4971a2ed-69d3-448c-8f8f-b81924b28589" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc5d2704-40af-42ff-9903-2ee9dabfbe19", "AQAAAAEAACcQAAAAELOncKCSNYr4BN5cdQtIb9lR5gsqJNYAR2ukor6fr5Qb4HEtlo7J+vHDZahkVIq9gg==", "832d8d03-aade-4bf1-9ce4-930b0131fcf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faa26161-25e6-43a6-af03-41d7dec272cd", "AQAAAAEAACcQAAAAEO31ril/z+W1pmeiIhuqUZUbAWPmzbL/ZPp5B2VKWTBFbYvjHYXip5jVjYVbD+AT3g==", "642b59e9-a90e-4bcb-b7bc-78bf0860a5ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "776eb034-b678-4ead-b14e-582557d5cbf2", "AQAAAAEAACcQAAAAECkKYvnqze6s/DJXQ0a4DWXUGjErmbB0vtaP1Sw4wcEJ3b7xlI87U4ro9jBQxxlCEg==", "4cd1eb67-0ed7-4fe8-804a-98131db4c6a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63f03adc-1c22-4d49-8a97-bed685c17c5a", "AQAAAAEAACcQAAAAEIrMXxW2hX5b8VQx+CSVeMo4pTiEStooL4Z1Zv1KJV/et8MSJeySsPgulik9hM8xNw==", "9be5c86f-6c2f-4671-9986-c19c216c7daf" });

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 648, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 649, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 650, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 651, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 652, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 16, 13, 17, 51, 653, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditTemplates",
                keyColumns: new[] { "FocusAreaID", "ObjectiveID" },
                keyValues: new object[] { 1, 16 },
                column: "AuditObject",
                value: "{\r\n  \"objectiveName\": \"APO11\",\r\n  \"objectiveDescription\": \"Define and communicate quality requirements in all processes, procedures and related enterprise outcomes. Enable controls, ongoing monitoring and the use of proven practices and standards in continuous improvement and efficiency efforts.\",\r\n  \"objectivePurpose\": \"Ensure consistent delivery of technology solutions and services to meet the quality requirements of the enterprise and satisfy stakeholder needs.\",\r\n  \"typeOfObjective\": \"Management\",\r\n  \"maturityLevel\": 0,\r\n  \"maturityLevel0PercFinal\": 0,\r\n  \"maturityLevel1PercFinal\": 0,\r\n  \"maturityLevel2PercFinal\": 0,\r\n  \"maturityLevel3PercFinal\": 0,\r\n  \"maturityLevel4PercFinal\": 0,\r\n  \"maturityLevel5PercFinal\": 0,\r\n  \"structuresImage\": \"https://i.imgur.com/W0bWH7f.png\",\r\n  \"components\": [\r\n    {\r\n      \"componentCode\": \"EG\",\r\n      \"componentDescription\": \"Enterprise Goals\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"EG01\",\r\n          \"subComponentName\": \"Portfolio of competitive products and services\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that meet or exceed targets in revenues and/or market share\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that meet or exceed customer satisfaction targets\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that provide competitive advantage\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Time to market for new products and services\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG04\",\r\n          \"subComponentName\": \"Quality of financial information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction survey of key stakeholders regarding the transparency, understanding and accuracy of enterprise financial information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Cost of noncompliance with finance-related regulations\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n\r\n        {\r\n          \"subComponentCode\": \"EG07\",\r\n          \"subComponentName\": \"Quality of management information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Degree of board and executive management satisfaction with decision-making information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Number of incidents caused by incorrect business decisions based on inaccurate information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Time to provide information supporting effective business decisions\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Timeliness of management information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG08\",\r\n          \"subComponentName\": \"Optimization of internal business process functionality\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of board and executive management with business process capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of customers with service delivery capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of suppliers with supply chain capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG12\",\r\n          \"subComponentName\": \"Managed digital transformation programs\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Number of programs on time and within budget\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of stakeholders satisfied with program delivery\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of business transformation programs stopped\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of business transformation programs with regular reported status updates\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n\r\n    {\r\n      \"componentCode\": \"AG\",\r\n      \"componentDescription\": \"Alignment Goals\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"AG10\",\r\n          \"subComponentName\": \"Quality of I&T management information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Level of user satisfaction with quality, timeliness and availability of I&T-related management information, taking into account available resources\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Ratio and extent of erroneous business decisions in which erroneous or unavailable I&T-related information was a key factor\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Percentage of information meeting quality criteria\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n\r\n        {\r\n          \"subComponentCode\": \"AG09\",\r\n          \"subComponentName\": \"Delivering programs on time, on budget and meeting requirements and quality standards\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Number of programs/projects on time and within budget\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Number of programs needing significant rework due to quality defects\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Percent of stakeholders satisfied with program/project quality\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n\r\n    },\r\n    {\r\n      \"componentName\": \"A\",\r\n      \"componentDescription\": \"Processes\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"APO11.01\",\r\n          \"subComponentName\": \"Establish a quality management system (QMS).\",\r\n          \"subComponentDescription\": \"Establish and maintain a quality management system (QMS) that provides a standard formal and continuous approach to quality management of information. The QMS should enable technology and business processes to align with business requirements and enterprise quality management.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Ensure that the I&T control framework and the business and IT processes include a standard, formal and continuous approach to quality management that is aligned with enterprise requirements. Within the I&T control framework and the business and IT processes identify quality requirements and criteria (e.g. based on legal requirements and requirements from customers).\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Define roles, tasks, decision rights and responsibilities for quality management in the organizational structure.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Obtain input from management and external and internal stakeholders on the definition of quality requirements and quality management criteria.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Regularly monitor and review the QMS against agreed acceptance criteria. Include feedback from customers, users and management.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 5\",\r\n              \"questionDescription\": \"Respond to discrepancies in review results to continuously improve the QMS.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.1 Plan quality management\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.02  \",\r\n          \"subComponentName\": \"Focus quality management on customers.\",\r\n          \"subComponentDescription\": \"Focus quality management on customers by determining their requirements and ensuring integration in quality management practices.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \" Focus quality management on customers by determining internal and external customer requirements and ensuring alignment of the I&T standards and practices. Define and communicate roles and responsibilities concerning conflict resolution between the user/customer and the IT organization\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Manage the business needs and expectations for each business process, IT operational service and new solutions. Maintain their quality acceptance criteria.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Communicate customer requirements and expectations throughout the business and IT organization.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Periodically obtain customer views on business process and service provisioning and IT solution delivery. Determine the impact on I&T standards and practices and ensure that customer expectations are met and actioned.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Capture quality acceptance criteria for inclusion in SLAs\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Input\",\r\n              \"questionDescription\": \"Business and customer quality requirements\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"Outside COBIT\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Customer requirements for quality management\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO08.05;APO09.03;BAI01.07;BAI11.06\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Results of quality of service including customer feedback\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO08.05;APO09.05;BAI05.01;BAI07.07\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Acceptance criteria\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"BAI02.01;BAI02.02\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.03 \",\r\n          \"subComponentName\": \"Manage quality standards, practices and procedures and integrate quality management into key processes and solutions.\",\r\n          \"subComponentDescription\": \"Identify and maintain standards, procedures and practices for key processes to guide the enterprise in meeting the intent of the agreed quality management standards (QMS). This activity should align with I&T control framework requirements. Consider certification for key processes organizational units products or services.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 2\",\r\n              \"questionDescription\": \"Define the quality management standards, practices and procedures in line with the I&T control framework’s requirements and enterprise quality management criteria and policies.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Integrate the required quality management practices in key processes and solutions across the organization.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Consider the benefits and costs of quality certifications.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \" Effectively communicate the quality management approach (e.g., through regular, formal quality training programs).\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Record and monitor quality data. Use industry good practices for reference when improving and tailoring the enterprise’s quality practices.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Regularly review the continued relevance, efficiency and effectiveness of specific quality management processes. Monitor the achievement of quality objectives.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.2 Manage quality\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.04\",\r\n          \"subComponentName\": \" Perform quality monitoring, control and reviews\",\r\n          \"subComponentDescription\": \"Monitor the quality of processes and services on an ongoing basis in line with quality management standards. Define plan and implement measurements to monitor customer satisfaction with quality as well as the value provide by the quality management system (QMS). The information gathered should be used by the process owner to improve quality.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \". Prepare and conduct quality reviews for key organizational processes and solutions.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"For these key organizational processes and solutions, monitor goal-driven quality metrics aligned to overall quality objectives.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Evaluate performance and provide regular and formal reporting of service agreement performance, including deviations from the agreed values. Distribute this report to business relationship management.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Ensure that management and process owners regularly review quality management performance against defined quality metrics.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Analyze overall quality management performance results.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 5\",\r\n              \"questionDescription\": \"Report the quality management performance review results and initiate improvements where appropriate.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.3 Control quality\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.05\",\r\n          \"subComponentName\": \"Maintain continuous improvement\",\r\n          \"subComponentDescription\": \"Maintain and regularly communicate an overall quality plan that promotes continuous improvement. The plan should define the need for and benefits of continuous improvement. Collect and analyze  data about the quality management system (QMS) and improve its effectiveness. Correct non conformities to prevent recurrence.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 2\",\r\n              \"questionDescription\": \"Establish a platform to share good practices and capture information on defects and mistakes to enable learning from them\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Identify examples of excellent quality delivery processes that can benefit other services or projects. Share these with the service and project deliver teams to encourage improvement.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Identify recurring examples of quality defects. Determine their root cause, evaluate their impact and result, and agree on improvement actions with the service and/or project delivery teams.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Provide employees with training in the methods and tools of continual improvement\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Benchmark the results of the quality reviews against internal historical data, industry guidelines, standards and data from similar types  enterprises.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided., \",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"National Institute of Standards and Technology Framework for Improving Critical Infrastructure Cybersecurity v1.1 April 2018\",\r\n              \"detailedReference\": \"DE.DP Detection Processes\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality review benchmark results\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Examples of good practice to be shared\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Communications on continual improvement and best practices\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"B\",\r\n      \"componentDescription\": \"Organizational Structures\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"APO11.01\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.02 \",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.03 \",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.04\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.05\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentCode\": \"C\",\r\n      \"componentDescription\": \"Information Flows and Items\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"APO11.01\",\r\n          \"subComponentName\": \"Establish a quality management system (QMS).\",\r\n          \"subComponentDescription\": \"Establish and maintain a quality management system (QMS) that provides a standard formal and continuous approach to quality management of information. The QMS should enable technology and business processes to align with business requirements and enterprise quality management.\",\r\n          \"subComponentQuestions\": [\r\n\r\n            {\r\n              \"questionType\": \"Input\",\r\n              \"questionDescription\": \"Enterprisewide quality system\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"Outside COBIT\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Results of QMS effectiveness reviews\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"BAI03.06\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality management plans\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO14.04;APO14.06;BAI01.07;BAI11.05\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality management system (QMS) roles responsibilities and decision rights\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO01.05;DSS06.03\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.02  \",\r\n              \"subComponentName\": \"Focus quality management on customers.\",\r\n              \"subComponentDescription\": \"Focus quality management on customers by determining their requirements and ensuring integration in quality management practices.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"Business and customer quality requirements\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"Outside COBIT\",\r\n                  \"outputTo\": \"No data provided.,\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Customer requirements for quality management\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.03;BAI01.07;BAI11.06\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality of service including customer feedback\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.05;BAI05.01;BAI07.07\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Acceptance criteria\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"BAI02.01;BAI02.02\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n\r\n              ]\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.03 \",\r\n              \"subComponentName\": \"Manage quality standards, practices and procedures and integrate quality management into key processes and solutions.\",\r\n              \"subComponentDescription\": \"Identify and maintain standards, procedures and practices for key processes to guide the enterprise in meeting the intent of the agreed quality management standards (QMS). This activity should align with I&T control framework requirements. Consider certification for key processes organizational units products or services.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"Approved quality reviews\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"BAI02.04\",\r\n                  \"outputTo\": \"No data provided.,\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Available quality certifications • Industry good practices\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"Outside COBIT\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Quality management standards\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Root causes of quality delivery failures\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.02;APO09.04;BAI07.08;MEA02.04; MEA04.04\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality monitoring\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.04;BAI07.08\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n              ]\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.04\",\r\n              \"subComponentName\": \" Perform quality monitoring, control and reviews\",\r\n              \"subComponentDescription\": \"Monitor the quality of processes and services on an ongoing basis in line with quality management standards. Define plan and implement measurements to monitor customer satisfaction with quality as well as the value provide by the quality management system (QMS). The information gathered should be used by the process owner to improve quality.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Quality assurance plan •Quality review results exceptions and corrections\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputFrom\": \"sring,\",\r\n                  \"inputFrom\": \"BAI03.06\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Incident status and trends report • Status of request fulfilment and trends report\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"DSS02.07\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Process quality of service goals and metrics\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality reviews and audits\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.04; APO09.05;BAI07.08\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n\r\n              ]\r\n\r\n\r\n\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.05\",\r\n              \"subComponentName\": \"Maintain continuous improvement\",\r\n              \"subComponentDescription\": \"Maintain and regularly communicate an overall quality plan that promotes continuous improvement. The plan should define the need for and benefits of continuous improvement. Collect and analyze  data about the quality management system (QMS) and improve its effectiveness. Correct non conformities to prevent recurrence.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Quality review benchmark results\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Examples of good practice to be shared\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Communications on continual improvement and best practices\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n              ]\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"D\",\r\n      \"componentDescription\": \"Peoples, Skills and Competencies\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"ICT quality strategy development\",\r\n          \"relatedGuidance\": \"e-Competence Framework (e-CF)—A common European Framework for ICT Professionals in all industry sectors—Part 1:Framework 2016 \",\r\n          \"detailedReference\": \"D. Enable—D.2. ICT Quality Strategy Development\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUAS\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUMG\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUST\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"E\",\r\n      \"componentDescription\": \"Principles Policies and Procedures\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"relevantPolicy\": \"Quality management policy\",\r\n          \"policyDescription\": \"Captures management’s vision of enterprise quality objectives acceptable level of quality and duties of specific teams and entities to ensure quality.\",\r\n          \"detailedGuidance\": \"No data provided.\",\r\n          \"detailedReference\": \"No data provided.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"F\",\r\n      \"componentDescription\": \"Culture, Ethics and Behavior\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"keyCultureElement\": \"Promote a culture of quality and continual improvement. Maintain, and regularly communicate the need for and benefits of quality and continuous improvement.\",\r\n          \"relatedGuidance\": \"No data provided.\",\r\n          \"detailedReference\": \"No data provided.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"G\",\r\n      \"componentDescription\": \"Services, Infrastructure and Applications\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionDescription\": \" QMS\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionDescription\": \"Third-party quality assurance services\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    }\r\n  ]\r\n}\r\n  ");

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 2,
                column: "UserAuditObject",
                value: "{\r\n  \"objectiveName\": \"APO11\",\r\n  \"objectiveDescription\": \"Define and communicate quality requirements in all processes, procedures and related enterprise outcomes. Enable controls, ongoing monitoring and the use of proven practices and standards in continuous improvement and efficiency efforts.\",\r\n  \"objectivePurpose\": \"Ensure consistent delivery of technology solutions and services to meet the quality requirements of the enterprise and satisfy stakeholder needs.\",\r\n  \"typeOfObjective\": \"Management\",\r\n  \"maturityLevel\": 0,\r\n  \"maturityLevel0PercFinal\": 0,\r\n  \"maturityLevel1PercFinal\": 0,\r\n  \"maturityLevel2PercFinal\": 0,\r\n  \"maturityLevel3PercFinal\": 0,\r\n  \"maturityLevel4PercFinal\": 0,\r\n  \"maturityLevel5PercFinal\": 0,\r\n  \"structuresImage\": \"https://i.imgur.com/W0bWH7f.png\",\r\n  \"components\": [\r\n    {\r\n      \"componentCode\": \"EG\",\r\n      \"componentDescription\": \"Enterprise Goals\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"EG01\",\r\n          \"subComponentName\": \"Portfolio of competitive products and services\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that meet or exceed targets in revenues and/or market share\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that meet or exceed customer satisfaction targets\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of products and services that provide competitive advantage\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Time to market for new products and services\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG04\",\r\n          \"subComponentName\": \"Quality of financial information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction survey of key stakeholders regarding the transparency, understanding and accuracy of enterprise financial information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Cost of noncompliance with finance-related regulations\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n\r\n        {\r\n          \"subComponentCode\": \"EG07\",\r\n          \"subComponentName\": \"Quality of management information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Degree of board and executive management satisfaction with decision-making information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Number of incidents caused by incorrect business decisions based on inaccurate information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Time to provide information supporting effective business decisions\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Timeliness of management information\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG08\",\r\n          \"subComponentName\": \"Optimization of internal business process functionality\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of board and executive management with business process capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of customers with service delivery capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Satisfaction levels of suppliers with supply chain capabilities\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"EG12\",\r\n          \"subComponentName\": \"Managed digital transformation programs\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Number of programs on time and within budget\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of stakeholders satisfied with program delivery\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of business transformation programs stopped\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Enterprise goal\",\r\n              \"questionDescription\": \"Percent of business transformation programs with regular reported status updates\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n\r\n    {\r\n      \"componentCode\": \"AG\",\r\n      \"componentDescription\": \"Alignment Goals\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"AG10\",\r\n          \"subComponentName\": \"Quality of I&T management information\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Level of user satisfaction with quality, timeliness and availability of I&T-related management information, taking into account available resources\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Ratio and extent of erroneous business decisions in which erroneous or unavailable I&T-related information was a key factor\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Percentage of information meeting quality criteria\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        },\r\n\r\n        {\r\n          \"subComponentCode\": \"AG09\",\r\n          \"subComponentName\": \"Delivering programs on time, on budget and meeting requirements and quality standards\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Number of programs/projects on time and within budget\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Number of programs needing significant rework due to quality defects\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Alignment goal\",\r\n              \"questionDescription\": \"Percent of stakeholders satisfied with program/project quality\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n\r\n    },\r\n    {\r\n      \"componentName\": \"A\",\r\n      \"componentDescription\": \"Processes\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"APO11.01\",\r\n          \"subComponentName\": \"Establish a quality management system (QMS).\",\r\n          \"subComponentDescription\": \"Establish and maintain a quality management system (QMS) that provides a standard formal and continuous approach to quality management of information. The QMS should enable technology and business processes to align with business requirements and enterprise quality management.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Ensure that the I&T control framework and the business and IT processes include a standard, formal and continuous approach to quality management that is aligned with enterprise requirements. Within the I&T control framework and the business and IT processes identify quality requirements and criteria (e.g. based on legal requirements and requirements from customers).\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Define roles, tasks, decision rights and responsibilities for quality management in the organizational structure.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Obtain input from management and external and internal stakeholders on the definition of quality requirements and quality management criteria.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Regularly monitor and review the QMS against agreed acceptance criteria. Include feedback from customers, users and management.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 5\",\r\n              \"questionDescription\": \"Respond to discrepancies in review results to continuously improve the QMS.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.1 Plan quality management\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.02  \",\r\n          \"subComponentName\": \"Focus quality management on customers.\",\r\n          \"subComponentDescription\": \"Focus quality management on customers by determining their requirements and ensuring integration in quality management practices.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \" Focus quality management on customers by determining internal and external customer requirements and ensuring alignment of the I&T standards and practices. Define and communicate roles and responsibilities concerning conflict resolution between the user/customer and the IT organization\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Manage the business needs and expectations for each business process, IT operational service and new solutions. Maintain their quality acceptance criteria.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Communicate customer requirements and expectations throughout the business and IT organization.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Periodically obtain customer views on business process and service provisioning and IT solution delivery. Determine the impact on I&T standards and practices and ensure that customer expectations are met and actioned.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Capture quality acceptance criteria for inclusion in SLAs\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Input\",\r\n              \"questionDescription\": \"Business and customer quality requirements\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"Outside COBIT\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Customer requirements for quality management\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO08.05;APO09.03;BAI01.07;BAI11.06\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Results of quality of service including customer feedback\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO08.05;APO09.05;BAI05.01;BAI07.07\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Acceptance criteria\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"BAI02.01;BAI02.02\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.03 \",\r\n          \"subComponentName\": \"Manage quality standards, practices and procedures and integrate quality management into key processes and solutions.\",\r\n          \"subComponentDescription\": \"Identify and maintain standards, procedures and practices for key processes to guide the enterprise in meeting the intent of the agreed quality management standards (QMS). This activity should align with I&T control framework requirements. Consider certification for key processes organizational units products or services.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 2\",\r\n              \"questionDescription\": \"Define the quality management standards, practices and procedures in line with the I&T control framework’s requirements and enterprise quality management criteria and policies.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Integrate the required quality management practices in key processes and solutions across the organization.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Consider the benefits and costs of quality certifications.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \" Effectively communicate the quality management approach (e.g., through regular, formal quality training programs).\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Record and monitor quality data. Use industry good practices for reference when improving and tailoring the enterprise’s quality practices.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Regularly review the continued relevance, efficiency and effectiveness of specific quality management processes. Monitor the achievement of quality objectives.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.2 Manage quality\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.04\",\r\n          \"subComponentName\": \" Perform quality monitoring, control and reviews\",\r\n          \"subComponentDescription\": \"Monitor the quality of processes and services on an ongoing basis in line with quality management standards. Define plan and implement measurements to monitor customer satisfaction with quality as well as the value provide by the quality management system (QMS). The information gathered should be used by the process owner to improve quality.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \". Prepare and conduct quality reviews for key organizational processes and solutions.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"For these key organizational processes and solutions, monitor goal-driven quality metrics aligned to overall quality objectives.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Evaluate performance and provide regular and formal reporting of service agreement performance, including deviations from the agreed values. Distribute this report to business relationship management.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Ensure that management and process owners regularly review quality management performance against defined quality metrics.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \" Analyze overall quality management performance results.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 5\",\r\n              \"questionDescription\": \"Report the quality management performance review results and initiate improvements where appropriate.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"PMBOK Guide Sixth Edition, 2017\",\r\n              \"detailedReference\": \"Part 1: 8.3 Control quality\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n\r\n          ]\r\n        },\r\n        {\r\n          \"subComponentCode\": \"APO11.05\",\r\n          \"subComponentName\": \"Maintain continuous improvement\",\r\n          \"subComponentDescription\": \"Maintain and regularly communicate an overall quality plan that promotes continuous improvement. The plan should define the need for and benefits of continuous improvement. Collect and analyze  data about the quality management system (QMS) and improve its effectiveness. Correct non conformities to prevent recurrence.\",\r\n          \"subComponentQuestions\": [\r\n            {\r\n              \"questionType\": \"Maturity Level 2\",\r\n              \"questionDescription\": \"Establish a platform to share good practices and capture information on defects and mistakes to enable learning from them\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Identify examples of excellent quality delivery processes that can benefit other services or projects. Share these with the service and project deliver teams to encourage improvement.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Identify recurring examples of quality defects. Determine their root cause, evaluate their impact and result, and agree on improvement actions with the service and/or project delivery teams.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 3\",\r\n              \"questionDescription\": \"Provide employees with training in the methods and tools of continual improvement\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Maturity Level 4\",\r\n              \"questionDescription\": \"Benchmark the results of the quality reviews against internal historical data, industry guidelines, standards and data from similar types  enterprises.\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided., \",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Related Guidance\",\r\n              \"questionDescription\": \"No data provided.\",\r\n              \"relatedGuidance\": \"National Institute of Standards and Technology Framework for Improving Critical Infrastructure Cybersecurity v1.1 April 2018\",\r\n              \"detailedReference\": \"DE.DP Detection Processes\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality review benchmark results\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Examples of good practice to be shared\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Communications on continual improvement and best practices\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"B\",\r\n      \"componentDescription\": \"Organizational Structures\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"APO11.01\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.02 \",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.03 \",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.04\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"APO11.05\",\r\n          \"questionDescription\": \"Roles, responsibilities and authorities are defined, assigned and accepted by appropriate Business Management, IT Management and the Board.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentCode\": \"C\",\r\n      \"componentDescription\": \"Information Flows and Items\",\r\n      \"componentPercFinal\": 0,\r\n      \"subComponents\": [\r\n        {\r\n          \"subComponentCode\": \"APO11.01\",\r\n          \"subComponentName\": \"Establish a quality management system (QMS).\",\r\n          \"subComponentDescription\": \"Establish and maintain a quality management system (QMS) that provides a standard formal and continuous approach to quality management of information. The QMS should enable technology and business processes to align with business requirements and enterprise quality management.\",\r\n          \"subComponentQuestions\": [\r\n\r\n            {\r\n              \"questionType\": \"Input\",\r\n              \"questionDescription\": \"Enterprisewide quality system\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"inputFrom\": \"Outside COBIT\",\r\n              \"outputTo\": \"No data provided.,\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Results of QMS effectiveness reviews\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"BAI03.06\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality management plans\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO14.04;APO14.06;BAI01.07;BAI11.05\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"questionType\": \"Output\",\r\n              \"questionDescription\": \"Quality management system (QMS) roles responsibilities and decision rights\",\r\n              \"relatedGuidance\": \"No data provided.\",\r\n              \"detailedReference\": \"No data provided.\",\r\n              \"outputTo\": \"APO01.05;DSS06.03\",\r\n              \"inputFrom\": \"No data provided.\",\r\n              \"questionAnswer\": 0,\r\n              \"questionScore\": 0,\r\n              \"questionComment\": \"\"\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.02  \",\r\n              \"subComponentName\": \"Focus quality management on customers.\",\r\n              \"subComponentDescription\": \"Focus quality management on customers by determining their requirements and ensuring integration in quality management practices.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"Business and customer quality requirements\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"Outside COBIT\",\r\n                  \"outputTo\": \"No data provided.,\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Customer requirements for quality management\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.03;BAI01.07;BAI11.06\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality of service including customer feedback\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.05;BAI05.01;BAI07.07\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Acceptance criteria\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"BAI02.01;BAI02.02\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n\r\n              ]\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.03 \",\r\n              \"subComponentName\": \"Manage quality standards, practices and procedures and integrate quality management into key processes and solutions.\",\r\n              \"subComponentDescription\": \"Identify and maintain standards, procedures and practices for key processes to guide the enterprise in meeting the intent of the agreed quality management standards (QMS). This activity should align with I&T control framework requirements. Consider certification for key processes organizational units products or services.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"Approved quality reviews\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"BAI02.04\",\r\n                  \"outputTo\": \"No data provided.,\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Available quality certifications • Industry good practices\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"Outside COBIT\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Quality management standards\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Root causes of quality delivery failures\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.02;APO09.04;BAI07.08;MEA02.04; MEA04.04\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality monitoring\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.04;BAI07.08\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n              ]\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.04\",\r\n              \"subComponentName\": \" Perform quality monitoring, control and reviews\",\r\n              \"subComponentDescription\": \"Monitor the quality of processes and services on an ongoing basis in line with quality management standards. Define plan and implement measurements to monitor customer satisfaction with quality as well as the value provide by the quality management system (QMS). The information gathered should be used by the process owner to improve quality.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Quality assurance plan •Quality review results exceptions and corrections\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputFrom\": \"sring,\",\r\n                  \"inputFrom\": \"BAI03.06\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Input\",\r\n                  \"questionDescription\": \"• Incident status and trends report • Status of request fulfilment and trends report\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"inputFrom\": \"DSS02.07\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Process quality of service goals and metrics\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Results of quality reviews and audits\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"APO08.05;APO09.04; APO09.05;BAI07.08\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n\r\n              ]\r\n\r\n\r\n\r\n            },\r\n            {\r\n              \"subComponentCode\": \"APO11.05\",\r\n              \"subComponentName\": \"Maintain continuous improvement\",\r\n              \"subComponentDescription\": \"Maintain and regularly communicate an overall quality plan that promotes continuous improvement. The plan should define the need for and benefits of continuous improvement. Collect and analyze  data about the quality management system (QMS) and improve its effectiveness. Correct non conformities to prevent recurrence.\",\r\n              \"subComponentQuestions\": [\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Quality review benchmark results\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Examples of good practice to be shared\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                },\r\n                {\r\n                  \"questionType\": \"Output\",\r\n                  \"questionDescription\": \"Communications on continual improvement and best practices\",\r\n                  \"relatedGuidance\": \"No data provided.\",\r\n                  \"detailedReference\": \"No data provided.\",\r\n                  \"outputTo\": \"All APO;All BAI; All DSS;All MEA\",\r\n                  \"inputFrom\": \"No data provided.\",\r\n                  \"questionAnswer\": 0,\r\n                  \"questionScore\": 0,\r\n                  \"questionComment\": \"\"\r\n                }\r\n              ]\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"D\",\r\n      \"componentDescription\": \"Peoples, Skills and Competencies\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"ICT quality strategy development\",\r\n          \"relatedGuidance\": \"e-Competence Framework (e-CF)—A common European Framework for ICT Professionals in all industry sectors—Part 1:Framework 2016 \",\r\n          \"detailedReference\": \"D. Enable—D.2. ICT Quality Strategy Development\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUAS\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUMG\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionSkill\": \"Quality assurance\",\r\n          \"relatedGuidance\": \"Skills Framework for the Information Age V6, 2015\",\r\n          \"detailedReference\": \"QUST\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"E\",\r\n      \"componentDescription\": \"Principles Policies and Procedures\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"relevantPolicy\": \"Quality management policy\",\r\n          \"policyDescription\": \"Captures management’s vision of enterprise quality objectives acceptable level of quality and duties of specific teams and entities to ensure quality.\",\r\n          \"detailedGuidance\": \"No data provided.\",\r\n          \"detailedReference\": \"No data provided.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"F\",\r\n      \"componentDescription\": \"Culture, Ethics and Behavior\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"keyCultureElement\": \"Promote a culture of quality and continual improvement. Maintain, and regularly communicate the need for and benefits of quality and continuous improvement.\",\r\n          \"relatedGuidance\": \"No data provided.\",\r\n          \"detailedReference\": \"No data provided.\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"componentName\": \"G\",\r\n      \"componentDescription\": \"Services, Infrastructure and Applications\",\r\n      \"componentPercFinal\": 0,\r\n      \"componentQuestions\": [\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionDescription\": \" QMS\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        },\r\n        {\r\n          \"questionType\": \"Component question\",\r\n          \"questionDescription\": \"Third-party quality assurance services\",\r\n          \"questionAnswer\": 0,\r\n          \"questionScore\": 0,\r\n          \"questionComment\": \"\"\r\n        }\r\n      ]\r\n    }\r\n  ]\r\n}\r\n  ");
        }
    }
}
