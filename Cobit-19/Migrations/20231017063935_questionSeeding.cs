using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class questionSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnswerRange",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Odds",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                column: "ConcurrencyStamp",
                value: "973f7e29-ba72-41cd-8bab-adc4d0db7b9d");

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

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerRange",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Odds",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f152e100-ccdd-4b05-ab3f-441f6074c4b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "effe181a-9ebd-4ef0-9ff9-05ae97a9eb75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "13e6496a-2eb8-4ac3-a9d2-1387cd53c4ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "4b6e8324-82d3-429b-8c81-c2f868af5165");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a",
                column: "ConcurrencyStamp",
                value: "d6dde821-019c-40e6-aa91-a43753e8cb9e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04d62d26-1f37-483c-972d-5f95ec9fd964", "AQAAAAEAACcQAAAAEMCWufTHfUcmVm9QpzVU3d01XjwkMjEvbvZsHuK7Xy6CVYobs7J2bk4x/8UjvZOyyQ==", "22942b91-a647-4c84-b8d8-5d575c82610d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ead258f-9b70-415b-981e-017cb682c09d", "AQAAAAEAACcQAAAAECr3xutbDzkU/VzjQx9gF+E2sm2yVnanHhZ4Qm07w3BE0VbrCkZF+ZrDGWeOD1T9QQ==", "6d6ba72f-e24b-4391-afec-d78f9bd29303" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d0acaac-b493-44b4-a9a4-50e06b7acae5", "AQAAAAEAACcQAAAAEGUdOPB19YtyR9vCU9t72ijAhTiK0iOmLRAbBHY11TxSsXOBU3OKdj6TYBtt1bPKzA==", "b9cc5754-d70d-4d5b-87d0-fa26d0f276f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9781f122-1ed7-4d39-8552-0d56dc34f2ae", "AQAAAAEAACcQAAAAEBHmd4HPzMgB9v5eM36pK5cpvAxTk6cqewXlac8dGUIhy/K6L55u6FW1/zvizCnRMA==", "959ab066-bae9-428f-9382-ac0520506626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff77fac2-47c5-44c1-8ce4-b04f18e8f645", "AQAAAAEAACcQAAAAEFKdJANF7ZpKI6BL1dWCwtUgH9GdyaKMeAcxtJgSFNd7WQdPAJQ0fdW4XqXlrCdQSA==", "0c6737ca-d957-4d74-9c16-3a06e285cc02" });
        }
    }
}
