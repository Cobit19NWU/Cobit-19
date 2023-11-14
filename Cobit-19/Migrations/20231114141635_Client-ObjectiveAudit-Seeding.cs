using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class ClientObjectiveAuditSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "8dd4d388-672f-4967-a478-3b64eff065c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "ef59e775-43a9-4ec5-92cb-2feedb6f1fc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "a05fd879-f9e0-4a88-9cfa-5206a824e437");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "66dac217-2f8a-41cb-88bf-1c5771a79f61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "012865a1-d409-4d2e-a0c7-68843bed9216");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa276290-5601-4178-aae5-6f9e730f142b", "AQAAAAEAACcQAAAAEDjYN52QfRFXXjM3HcXYpIyV+SD1P4gDkGqc5Gnsaf3lRbitmbjZwQsowhTnB9DiWQ==", "44f071e9-56fc-4e3a-b266-aa36977a0d3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5202ea6d-04b2-433c-93d9-ffcaf536152d", "AQAAAAEAACcQAAAAEO3u+NMME8hbwGMWmlxCHySN1V3nYH62MELtP7wsl/JGGJOvzepneW2fY7kEzRh6gw==", "fc854e95-0767-4eea-a60f-f39dcb57f505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fb61ab8-a9f9-4aa1-80e5-6b3746f16776", "AQAAAAEAACcQAAAAEDBCOqf6J1IC3ImsqAUUFMKrnG40cqlGKxK7f5PP+K4NVbt/eKnICvXYbTVUbyJVjA==", "e6461930-8121-498d-adef-1e63eb797833" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ceea6c1e-41e4-4ac2-b85c-7178a0b8a640", "AQAAAAEAACcQAAAAEFLOw2KWhs7eFRiChHOsHanek281ORTuDa5AS7/62eSeuogeBCl+M6OyWvPvPqZqcA==", "9776168d-c4cb-4ac9-bdcc-9a01eb90abc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8637679-2614-47a7-8944-1c003bdf7d6b", "AQAAAAEAACcQAAAAEDm4wGLc+LrW4uE/oNeLIZM/8vEGkclKN5+O6DNgm/fPZngZX/v1SjWwthbfroX5MA==", "b459c598-3543-41f2-96a7-4d3fa0447823" });

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.InsertData(
                table: "ObjectiveAuditMembers",
                columns: new[] { "ApplicationUserID", "ObjectiveAuditID", "DateAdded" },
                values: new object[,]
                {
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 1, new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(912) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 2, new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(2580) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 3, new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(4553) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 4, new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(5826) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 5, new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(7920) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 6, new DateTime(2023, 11, 14, 16, 16, 35, 158, DateTimeKind.Local).AddTicks(9888) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 7, new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(1573) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 8, new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(3189) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 9, new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(4495) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 10, new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(5929) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 11, new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(7434) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 12, new DateTime(2023, 11, 14, 16, 16, 35, 159, DateTimeKind.Local).AddTicks(9306) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 13, new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(779) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 14, new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(2071) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 15, new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(4154) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 16, new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(5456) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 17, new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(8122) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 18, new DateTime(2023, 11, 14, 16, 16, 35, 160, DateTimeKind.Local).AddTicks(9371) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 19, new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(866) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 20, new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(1877) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 21, new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(3401) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 22, new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(4458) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 23, new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(5823) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 24, new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(6804) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 25, new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(8487) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 26, new DateTime(2023, 11, 14, 16, 16, 35, 161, DateTimeKind.Local).AddTicks(9713) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 27, new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(895) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 28, new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(1995) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 29, new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(3488) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 30, new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(5108) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 31, new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(6795) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 32, new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(8477) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 33, new DateTime(2023, 11, 14, 16, 16, 35, 162, DateTimeKind.Local).AddTicks(9710) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 34, new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(710) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 35, new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(2025) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 36, new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(2916) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 37, new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(4117) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 38, new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(5161) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 39, new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(6101) },
                    { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 40, new DateTime(2023, 11, 14, 16, 16, 35, 163, DateTimeKind.Local).AddTicks(7461) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 1 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 2 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 3 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 4 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 5 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 6 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 7 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 8 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 9 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 10 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 11 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 12 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 13 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 14 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 15 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 16 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 17 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 18 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 19 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 20 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 21 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 22 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 23 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 24 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 25 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 26 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 27 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 28 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 29 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 30 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 31 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 32 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 33 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 34 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 35 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 36 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 37 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 38 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 39 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "b2c3d4e5-f6a7-1234-5678-0987654321dc", 40 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "bfb4f29a-6fa9-496a-ac18-51a71064751b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "e4793bdb-c0dc-4bc0-a907-f1452e6a579b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "554cfca3-aaea-4c3b-80a2-28820228b3c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "6aa85cd9-1205-4a70-887d-edbfe74ef4e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "1d3aa58a-bac9-42d5-9922-56c60589e539");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0cf54fd-d7ba-40ec-89c6-4a911aacbb1e", "AQAAAAEAACcQAAAAEL/MfCZV3HO5D7WH4sEaaagnWBVdJp5s9/J/2T5Yb7nq/lpGYoXYJFbgYuyQyR/GzA==", "f89983e6-48cb-41be-8bc0-6edd4f854dcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a2ab2cd-6a6d-4242-a614-c5c574dcc2a3", "AQAAAAEAACcQAAAAEMjLlOPMqRRB2RBcffPVWWOWLq0XouYe0JmOzqx5whwE6mxBuaTFAXnulsY87B4WhA==", "602e78bd-d808-418f-b499-42037572bdce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cd7c288-65db-4930-9498-dd05998f31d5", "AQAAAAEAACcQAAAAEAGfhJAfGybD0Kfu0qDDVtjr8HyGY4iNnKwD9diCkLeAFybQzoTUgtVgMiUtBYwHUA==", "22b227e9-2ba4-4819-aa74-9329e9db3715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0b83fbb-6bbd-41ee-b490-7161e8f16709", "AQAAAAEAACcQAAAAENdnEDNf+jBH2KnB4UR7ZWoz4We5QtngvJ+R7v9SnDTmH30Vz37YA5SN+anVk8aeSw==", "8ef29946-7629-4c93-8f01-b6a54153328d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b97d7c3a-4e2f-4957-88a6-540009ff1a41", "AQAAAAEAACcQAAAAEElrOn2uCnax+pp03sHvUKWOpjLYDz7Zw720rd3/eOBVcH57lCSCmL86FJk33T5/uQ==", "5ae0d5e2-84ba-44ba-95a8-af50638c0cca" });

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 709, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 709, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 709, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 17, 41, 3, 709, DateTimeKind.Local).AddTicks(3724));
        }
    }
}
