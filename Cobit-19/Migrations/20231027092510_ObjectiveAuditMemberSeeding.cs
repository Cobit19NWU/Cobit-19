using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class ObjectiveAuditMemberSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2e29c528-813e-4211-8f3b-ae3da52869c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "544b0ccc-37d9-4c49-a997-4ae2f0275839");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "283989f2-a18a-4bca-89b5-203338fe394a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "bd0581b6-9cb6-4c47-964e-e4bf09ad809e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "2f5e1ed6-724b-455e-b7b0-9ec43aba9e9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fe12958-3bea-43e5-84fe-9acd3ad9de71", "AQAAAAEAACcQAAAAEJ+m39zjededjDymCd5eJfTKEGxS+PHFt2kaAl1QHgxSTmDHo31UCWlowQE4btokLQ==", "59a745ec-1bc6-462f-b8fe-9af4abc3b54b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0899464-f2a3-478d-b2b2-ee8368e28d27", "AQAAAAEAACcQAAAAEI1DUOl0Dc+qUnY7SRb/mhEX9tOGsjJxW7Gil4rVZfkEvwyQqtUa5P40dAI0eYAlBg==", "083c027b-b896-4b84-b22b-9d6670bc6e52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d51b881-2e95-475b-83dd-cde97bb32911", "AQAAAAEAACcQAAAAEGmB1ZpTTIS7wW8XM57NFThzk9jMavQvhqC5O5i6mvLLXc38Kz9SDKVYXhzaT4Xjag==", "a59d4c65-2bfc-44c1-9ab2-90f1d9d3afda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b1cc545-22a8-46e2-989b-8842fd6a989b", "AQAAAAEAACcQAAAAEPOjaYA8efDOSb2sijup/MqTlk0Uy+Gg2UGwGV/otxudxv/issU+jg0RT+jT4GSBWw==", "aabbd1c0-fe69-465a-8d61-03fcf7cc3e57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abab5248-80c5-4861-bbe1-b2b9da7b06a4", "AQAAAAEAACcQAAAAEIacfYzQL7ESPkEIN/8MWzxQj8Be4dju5J+B2Af8TMvsOLAvPRMTUOWO6eWqEajLIQ==", "e862cc6c-28c0-4be3-96b4-c58c5fe5c83d" });

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 9,
                column: "Information",
                value: "The methods the enterprise adopts can be classified according to the categories: Agile - The enterprise uses Agile development working methods for its software development. DevOps - The enterprise uses DevOps working methods for software building, deployment and operations. Traditional - The enterprise uses a more classic approach towards software development (waterfall) separates software development and operations.");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Description", "Information" },
                values: new object[] { "Technology Adoption Strategy", "The technology adoption strategy can be classified according to the categories: First mover - The enterprise generally adopts new technologies as early as possible and tries to gain a first-mover advantage. Follower - The enterprise typically waits for new technology to become mainstream and proven before adopting them. Slow adopter - The enterprise is very late in adopting new technologies." });

            migrationBuilder.InsertData(
                table: "ObjectiveAuditMembers",
                columns: new[] { "ApplicationUserID", "ObjectiveAuditID", "DateAdded" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 16, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6025) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 17, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6042) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 18, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6045) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 19, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6049) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 20, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6052) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 21, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6057) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 22, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6061) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 23, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6064) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 24, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6067) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 25, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6072) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 26, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6075) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 27, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6078) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 28, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6081) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 29, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6084) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 30, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6087) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 31, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6090) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 32, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6093) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 33, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6097) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 34, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6101) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 35, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6104) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 36, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6107) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 37, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6110) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 38, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6113) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 39, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6116) },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 40, new DateTime(2023, 10, 27, 11, 25, 10, 226, DateTimeKind.Local).AddTicks(6147) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 16 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 17 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 18 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 19 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 20 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 21 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 22 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 23 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 24 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 25 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 26 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 27 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 28 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 29 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 30 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 31 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 32 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 33 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 34 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 35 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 36 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 37 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 38 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 39 });

            migrationBuilder.DeleteData(
                table: "ObjectiveAuditMembers",
                keyColumns: new[] { "ApplicationUserID", "ObjectiveAuditID" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 40 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c5d83bcf-0d26-47ab-8658-5b87d4066efe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "998521e2-0106-4e14-88cd-b843f6a9afae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "89c60682-84c4-4f85-8a93-d6ff700db5a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "8dfc2715-729b-4eb8-b519-4b526436c7ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "a5ca82c3-93b1-4083-a442-bc91040a7b83");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8baf9aa-8fa1-464d-b178-b11c2d8e516a", "AQAAAAEAACcQAAAAED7wEBaj9eZWjo6/7o18wIaEKFiMSpaltPasHv6nRt32N6i1EgcALmPC/y+4+MHjWA==", "635c89fe-e254-472d-be7f-db75fe841174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65f89428-ca24-4b77-8679-12cd835151e4", "AQAAAAEAACcQAAAAED3tEPWEuQ93o834FC+1hkwo+qr5Bmi3I3/roKmrxVi7Gpn0mq2myoaV+CQXSBBXDQ==", "2ed259f6-1a64-44a6-95df-de7961586201" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a72fef3-8207-4f94-95ac-563a9c0f4884", "AQAAAAEAACcQAAAAEBdJHnuwi5vGeawtgUjAw0+ttGky0YFtXllqAFDEoPiI6hSxfW+J87kvc48Mg6n73w==", "14cc5bcb-ace9-4d7d-8895-10faafc9e63c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "099e7c36-4fb8-4554-bc89-76267abdef9b", "AQAAAAEAACcQAAAAEO8y0AfrO8YLptHU1RM6iVz6PSL61ttK2jCjIR9hImGrFzjKbAotzSIhwzxu0aBpwA==", "ba1967fa-ab86-4946-a93c-0c0166523d5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52707a5e-a6af-4cb1-8a2a-0da660e60a93", "AQAAAAEAACcQAAAAEKd/Ddf0lt3p3Rq8tyqrfeVRE0y1dXGtFzATCduAsNeJ9HDUjep7LXSMo1R295ONcA==", "bfcb4977-ba00-4943-a0e2-a61e2940e00d" });

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 9,
                column: "Information",
                value: "The methods the enterprise adopts can be classified according to the categories: Agile - The enterprise uses Agile development working methods for its software development. DevOps - The enterprise uses DevOps working methods for software building, deployment and operations. Traditional - The enterprise uses a more classic approach towards software development (waterfall)                                  separates software development and operations.");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Description", "Information" },
                values: new object[] { "The technology adoption strategy can be classified according to the categories: First mover - The enterprise generally adopts new technologies as early as possible and tries to gain a first-mover advantage. Follower - The enterprise typically waits for new technology to become mainstream and proven before adopting them. Slow adopter - The enterprise is very late in adopting new technologies.", null });
        }
    }
}
