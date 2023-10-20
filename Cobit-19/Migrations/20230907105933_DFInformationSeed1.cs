using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DFInformationSeed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 2,
                column: "Information",
                value: "Each of the thirteen enterprise goals must be rated between 1 (not important) and 5 (most important). Using the generic enterprise goals, determine the most important goals for the enterprise. It is advisable to select the top three to five most important enterprise goals; too many high-priority goals will lead to less meaningful goals cascade results. It is recommended to a maintain sufficient spread between values.");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 3,
                column: "Information",
                value: "The risk profile identifies the IT-related risk the enterprise is exposed to and indicates which areas of risk exceed the risk appetite. Each of the 19 risk categories contained in the risk profile design factor must be rated. <strong>Impact</strong> of the risk should it occur, as a value between <strong>1 (not important)</strong> and <strong>5 (critical)</strong>");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "d1f47f51-fd18-4fc1-87f1-e28c49da54cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "8e6388e3-de17-4ddd-bca7-268e034a8ea3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "826f8e8f-eaae-4172-904f-dfc2865a0309");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "56fdaeb1-6963-471b-bb54-c9d3529fbb9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f99eba75-1fdc-4e2c-be75-e50f731847af", "AQAAAAEAACcQAAAAEIhrnh+RBkwHFXaKbvB68xliYpubLvuVArBMk2i5gxOB102349CKsOcR6JcToZEaOQ==", "f96d618c-49fc-4377-8ccc-53cbb9afcfec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "979eb60f-bebe-4a35-a746-5ad60fd40791", "AQAAAAEAACcQAAAAECJ2IHcOA1h9IhYtmramQtVzf/6urRrVDSP8dXzKe6diQhXyZmd65Q/gg+yW9AGz8w==", "cfdc0dab-d3ff-4ad4-a089-3a8cdbe983b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3d40cb2-eca5-45aa-a800-3569c8e6b151", "AQAAAAEAACcQAAAAEBFYqsQkmSzO05coy8XIKw9tG3inXFWNHBxqpEAIEv4cZ8VqCsYh+b6EEC3l/SR03w==", "17199a23-d9ba-4e46-9880-d90faf6a077b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a4cb8d-d3d8-47a7-9437-751b3c5f076c", "AQAAAAEAACcQAAAAEPuV/0Wyn6I+aUfzpjJEseROdtokOz8rV08sshkErNOP/IsJkTvcsRdjiTUeVHU6iA==", "8b3a86c8-31a8-43d3-b8bf-a59eda770ec8" });

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 1,
                column: "Information",
                value: null);

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 2,
                column: "Information",
                value: null);

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 3,
                column: "Information",
                value: null);
        }
    }
}
