using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class HeadAuditorSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ObjectiveAuditMembers",
                columns: new[] { "ApplicationUserID", "ObjectiveAuditID", "DateAdded" },
                values: new object[,]
                {
                    { "fa567c12-5678-4321-bacd-87654321de1f", 1, new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(612) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 2, new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(3683) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 3, new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(6591) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 4, new DateTime(2023, 11, 12, 17, 41, 3, 700, DateTimeKind.Local).AddTicks(8795) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 5, new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(2265) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 6, new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(5711) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 7, new DateTime(2023, 11, 12, 17, 41, 3, 701, DateTimeKind.Local).AddTicks(8358) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 8, new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(969) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 9, new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(3145) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 10, new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(5368) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 11, new DateTime(2023, 11, 12, 17, 41, 3, 702, DateTimeKind.Local).AddTicks(9029) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 12, new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(2004) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 13, new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(4311) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 14, new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(6414) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 15, new DateTime(2023, 11, 12, 17, 41, 3, 703, DateTimeKind.Local).AddTicks(9089) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 16, new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(1258) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 17, new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(4495) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 18, new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(6620) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 19, new DateTime(2023, 11, 12, 17, 41, 3, 704, DateTimeKind.Local).AddTicks(8894) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 20, new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(829) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 21, new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(3164) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 22, new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(5045) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 23, new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(7182) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 24, new DateTime(2023, 11, 12, 17, 41, 3, 705, DateTimeKind.Local).AddTicks(9123) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 25, new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(1845) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 26, new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(4035) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 27, new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(6159) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 28, new DateTime(2023, 11, 12, 17, 41, 3, 706, DateTimeKind.Local).AddTicks(8183) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 29, new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(668) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 30, new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(3201) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 31, new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(5467) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 32, new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(7520) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 33, new DateTime(2023, 11, 12, 17, 41, 3, 707, DateTimeKind.Local).AddTicks(9587) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 34, new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(1522) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 35, new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(3462) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 36, new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(5262) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 37, new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(7445) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 38, new DateTime(2023, 11, 12, 17, 41, 3, 708, DateTimeKind.Local).AddTicks(9450) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 39, new DateTime(2023, 11, 12, 17, 41, 3, 709, DateTimeKind.Local).AddTicks(1349) },
                    { "fa567c12-5678-4321-bacd-87654321de1f", 40, new DateTime(2023, 11, 12, 17, 41, 3, 709, DateTimeKind.Local).AddTicks(3724) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 1 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 2 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 3 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 4 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 5 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 6 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 7 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 8 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 9 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 10 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 11 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 12 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 13 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 14 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 15 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 16 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 17 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 18 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 19 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 20 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 21 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 22 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 23 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 24 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 25 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 26 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 27 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 28 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 29 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 30 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 31 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 32 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 33 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 34 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 35 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 36 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 37 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 38 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 39 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "fa567c12-5678-4321-bacd-87654321de1f", 40 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "bf798a8f-5ee2-455a-9a3e-0f6d3a5b54be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "7b122180-e2de-4000-86ef-8b438adff087");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "e42fe02c-b0d0-4e22-9d62-b8c58bc7ed06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "15589e26-bddd-479e-ad60-d7d7705416a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "097766bc-7e4d-4790-a48c-710f5a2131d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d3913b2-27b0-4bed-b139-f7f952b1c2c5", "AQAAAAEAACcQAAAAEBeSzXCKZzSePlB8++mF0z+rN2MndLndKmsezE4NznPgp+3TdzKSftVQqKLsdUaVfg==", "9012de2e-e211-492a-9bb4-f37f589d45be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e12d489-fead-42ea-9093-7d84c4bee712", "AQAAAAEAACcQAAAAELKF/MU/3RpCboSKN93kLtTzQUb8TI65nRTuVqwSfpe9DEJSpgrmy2THr4+gOGP7dQ==", "eab854ae-1b84-42d4-b15a-909a568143c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9907ebd-31cc-454c-9d73-6a4fccb51de6", "AQAAAAEAACcQAAAAENW690k4V3bi2osq0agaJYxVpb/XvIFjxzBc1l3CCmC3kTKaBCEKFpdVMjxDOlaHXA==", "1d61bea1-1560-4892-9d5f-31918787f28e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db6348a2-2696-4ed4-a397-90af9c48f696", "AQAAAAEAACcQAAAAEOTQqvkhg+tGBpF88g5qOqDivBH7sl+n/T6Eu4WIrtWBwLn58Zf2llewELOEU3yUDA==", "07ff7215-82e8-4379-9851-8c3ece18d373" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a014419-6e40-4771-8242-8d5f94f49862", "AQAAAAEAACcQAAAAEFlNz1XclpmPthU0D8YcZPq3HmcJnYysqC8twBqZBWnihbtybG6AvrDHSLZYNd3heA==", "8067102c-a019-43d7-b550-b04d7e123fe6" });

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 1 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 129, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 2 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 130, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 3 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 130, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 4 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 131, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 5 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 131, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 6 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 132, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 7 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 132, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 8 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 133, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 9 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 133, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 10 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 134, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 11 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 134, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 12 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 135, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 13 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 135, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 14 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 136, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 15 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 136, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 16 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 137, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 17 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 137, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 18 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 138, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 19 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 138, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 20 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 138, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 21 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 139, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 22 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 139, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 23 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 140, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 24 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 140, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 25 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 140, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 26 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 141, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 27 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 141, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 28 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 142, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 29 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 142, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 30 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 143, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 31 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 143, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 32 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 144, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 33 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 144, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 34 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 145, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 35 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 145, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 36 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 145, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 37 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 146, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 38 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 146, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 39 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 146, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 40 },
                column: "DateAdded",
                value: new DateTime(2023, 11, 12, 9, 17, 17, 147, DateTimeKind.Local).AddTicks(2717));
        }
    }
}
