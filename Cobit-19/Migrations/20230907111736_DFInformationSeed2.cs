using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DFInformationSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                column: "Information",
                value: "Enterprises can have different strategies, expressed as one or more archetypes. \nEach of the four possible values for the enterprise strategy design factor must be rated between 1 (not important) and 5 (most important). \nIt is recommended to maintain a sufficient spread between values.");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 3,
                column: "Information",
                value: "The risk profile identifies the IT-related risk the enterprise is exposed to and indicates which areas of risk exceed the risk appetite. Each of the 19 risk categories contained in the risk profile design factor must be rated. Impact of the risk should it occur, as a value between 1 (not important) and 5 (critical)");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 4,
                column: "Information",
                value: "A related method for an I&T risk assessment for the enterprise is to consider which I&T-related issues it currently faces, or, in other words, what I&T-related risk has materialized. It is recommended to maintain a sufficient spread between values.");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 5,
                column: "Information",
                value: "The threat landscape under which the enterprise operates can be classified into two categories. Normal - The enterprise is operating under what are considered normal threat levels. High - Due to its geopolitical situation, industry sector or particular profile, the enterprise is operating in a high-threat environment.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3c2defc5-abbd-456d-bed5-d49133a9f4d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "58c916cb-c254-4301-aca6-5d658938ccac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "02d70bc4-33c1-4266-acde-7d7de5d7fd25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "c7cb4832-019c-447a-884a-7b7bd31dd06c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d02fa705-a5d6-47e9-9a36-464a5d517f44", "AQAAAAEAACcQAAAAEANq//nJfB8Qgx3TY0ux17XCzh58LQrNUQakzpktMpJ1uglpfa3f+8kOMYH46ClZWw==", "d4934411-8d56-494d-adfd-87d49b2224c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c403431-8f3f-484e-9516-beed68e04122", "AQAAAAEAACcQAAAAELzC+sJZYa1CV99/qFkjcUA8LACcExLxpaSuZ+ke6r3t28aeZgcgnuILIJns4t1Y8A==", "0bb6960b-56a4-4e74-8672-70bf383a53cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ea74153-7b56-4df5-9507-e3693153a73f", "AQAAAAEAACcQAAAAEN7MwtoN+O8Q1henDYvi+YTdlkcll0LG86ujS+8VK0prcCbJSmYH6Q58p18HPPTDKQ==", "06e419f1-7f95-4b56-ae18-0fede59ca0a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "411245c2-1f3f-47c3-96bd-c1be54ec18bc", "AQAAAAEAACcQAAAAEAu1W+OZ8HA0zT0DweS1AaxPheSqFHfWFuhxiWWub5BV8qsI5VDCTMddFy9dHuxDsw==", "f68ea863-413c-4dc2-a574-f1ac2dd4a338" });

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 1,
                column: "Information",
                value: "Enterprises can have different strategies, expressed as one or more archetypes. Each of the four possible values for the enterprise strategy design factor must be rated between 1 (not important) and 5 (most important). It is recommended to maintain a sufficient spread between values.");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 3,
                column: "Information",
                value: "The risk profile identifies the IT-related risk the enterprise is exposed to and indicates which areas of risk exceed the risk appetite. Each of the 19 risk categories contained in the risk profile design factor must be rated. <strong>Impact</strong> of the risk should it occur, as a value between <strong>1 (not important)</strong> and <strong>5 (critical)</strong>");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 4,
                column: "Information",
                value: null);

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 5,
                column: "Information",
                value: null);
        }
    }
}
