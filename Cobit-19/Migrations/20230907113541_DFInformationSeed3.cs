using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DFInformationSeed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "aa270c2d-7f57-48b3-be62-97ef84685d31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "8af978fe-82b1-417f-805d-c9d94915fd96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "ab5d7e93-6c85-475d-9d48-6d2e4bce54e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "af86f304-94f9-4ca1-8ba2-b982d780ebf0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fcb6637-5a40-4b7f-b5e1-66233f9abbd7", "AQAAAAEAACcQAAAAEAo8VntmOI8TY4Kz3LS7uSagkFhEEHtPGKW4rYz8lm997RbTWRCulk0G2Px0mQ5pgQ==", "e0f5676e-3096-483a-aa61-d7712accc8ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4dc0707-cbe3-45fb-be6b-c8a707043994", "AQAAAAEAACcQAAAAEPgQSqHNdUjzTHwIMdOHJrp4EiG6yyVPU28QAYbSxvFYuJpJ4ypfENqLXr01KJaOUw==", "7da1cc2f-9ef0-4918-833d-0d61cfb3ffec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b18b1ae-c06a-4d2c-84e4-80b268a8df16", "AQAAAAEAACcQAAAAEHVBcR4+E9AfqDKfWPQ6gDkqvXzALvmps/K2HbM4TZ22S20WbJK0AU7Vo7H+Pj+1JA==", "88b5c1c3-d17c-4491-bc58-12b68571677d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c1f14f0-3206-47f3-9ff5-31d8ae1cbb3d", "AQAAAAEAACcQAAAAENspimxIAWuEd5Al2eiSHJA/oXvD5f4Pk0lJRvbIx+R8Vnpu7DzyRl3Csf450vGirA==", "a1ef33f2-edf3-4edc-ba22-f4c85c5c8ef9" });

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 6,
                column: "Information",
                value: "The compliance requirements to which the enterprise is subject to, can be classified according to these categories. Low compliance requirements - The enterprise is subject to a minimal set of regular compliance requirements that are lower than average.\r\n Normal compliance requirements - The enterprise is subject to a set of regular compliance requirements that are common across different industries. High compliance requirements - The enterprise is subject to higher than average compliance requirements, most often related to the industry sector or geopolitical conditions");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 7,
                column: "Information",
                value: "");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 8,
                column: "Information",
                value: "");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 9,
                column: "Information",
                value: "");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 10,
                column: "Information",
                value: "The methods the enterprise adopts can be classified according to the categories outlined as follows: Agile - The enterprise uses Agile development working methods for its software development. DevOps - The enterprise uses DevOps working methods for software building, deployment and operations. <strong>Traditional</strong> - The enterprise uses a more classic approach towards software development (waterfall) and separates software development and operations.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "bfc94498-61db-4930-a0b5-6f0f99712f4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "d36d15a4-7c51-4d56-a6b7-4f8286c36533");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "6151d7b7-6005-4cb6-a5a3-ed019648785a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "a0a5b4c4-611c-4219-ad85-e3fdb023d601");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d9d3824-e581-4e5c-a570-0f2a0d6cf171", "AQAAAAEAACcQAAAAEMoA2xEwQgIV6h44xl3Pa5yTcGYsLV+GcD+tluOdYsY3rIWQHR1zob1gD0IH1HF/8g==", "38e2c9e3-37ff-4bc8-aede-2aadbb24a0de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11b176fb-ff7f-4a35-a5e1-b7238a863b00", "AQAAAAEAACcQAAAAENcsT9EyEb45SgW/pok5csCuIhrAjE8Mjaj+pFmvSShCVC/azvL/lCWD7RABmbnOdw==", "2bc83da5-394a-479e-abfa-6bd558b198a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28d2be10-8e1f-4846-ac2c-6d7693ad2ee7", "AQAAAAEAACcQAAAAEPCHNj9HKXkjQvZ/1Q04BqAIKF+KMImd7kyU7J011XKh3wg+f2WzL94e546j2Sq5ow==", "6832957b-4517-454e-a703-7374b58c3b26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "862d1d57-b21d-49ae-9870-b84cfc24d296", "AQAAAAEAACcQAAAAEIkAlqlff+bt2V/5g7rIGaGM3xTmzB30+B9nC37uB2QcPb6Q86YugTMoVx7W+D6/Fw==", "3828e1ac-8bc8-4bc6-beb6-88bf11e7d972" });

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 6,
                column: "Information",
                value: null);

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 7,
                column: "Information",
                value: null);

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 8,
                column: "Information",
                value: null);

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 9,
                column: "Information",
                value: null);

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 10,
                column: "Information",
                value: null);
        }
    }
}
