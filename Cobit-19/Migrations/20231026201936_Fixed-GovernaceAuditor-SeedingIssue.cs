using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class FixedGovernaceAuditorSeedingIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "89c60682-84c4-4f85-8a93-d6ff700db5a0", "GOVERNANCE AUDITOR" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "8d287541-c9b5-418a-86cb-aa4cf3b729f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "f8c1b30c-6c70-494b-b9a2-6f29723671bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "973f7e29-ba72-41cd-8bab-adc4d0db7b9d", " GOVERNANCE AUDITOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "1a0ae306-7a14-47ac-8664-9ff54ab76db5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "ed4d1a08-8cf3-4fec-8d11-51720c1e9566");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fb6aa55-9aed-4492-b76a-1d6d6344e048", "AQAAAAEAACcQAAAAECvEsx1Eip9XmFP/516PJAVqYp2k5qQjP/UE9DmNjFoycIg65YT+l6d10x8PuX07sA==", "578ea79a-d4c4-4f8e-a757-3067d28f695f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10a6f3b0-459f-4ab9-9515-cb3c3d5c8801", "AQAAAAEAACcQAAAAELBFTTBEbLk63fTTEjvmOOXM48A9Ug6Z6Cj5ztmVgj6z6yZQliasiqNUvWwei1gP0Q==", "8d657457-955e-43a0-a0e4-19d40213068b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c504a10c-9317-4f40-b654-183a363c992c", "AQAAAAEAACcQAAAAEKY0A4aO5E/tl2OrcBNgkqAnAFSP4SKmMr2FT6wB9Jv4nXFysDIdOZO74Mf3vO78IQ==", "c7bd56ac-db8e-4bae-8c04-4e250843013a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a943d2e-40fd-446b-b216-1d2caef8b1e5", "AQAAAAEAACcQAAAAEM+QUtw8qkAdRCbKQBOTnZmqzw9ym7Ab1vUz9zPC36PBLCNNUoeHafrs7IFH9f2U9A==", "f35caefc-a3eb-4469-9582-264e162f21b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ba92ae9-ef17-4b4d-b7d1-194e0d4b68c3", "AQAAAAEAACcQAAAAEO6m+BYbE79ADwGXmSudYuxLCiJI1jpQRWdk7G0BZh0sgPq/JYwSQXr77qdfLho31A==", "290bde2f-9945-4ebe-aaf2-fb1e86ee50c8" });
        }
    }
}
