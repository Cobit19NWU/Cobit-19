using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DFInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "DesignFactors",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Information",
                table: "DesignFactors");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "7a8c6b5a-4756-4a43-9532-e58fe559a528");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "5b0c4440-33b5-4d03-82d8-af11338185e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "9d0eb949-27d4-48b2-b2ba-95ccd5fbdc38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "295d52c0-335e-4845-bc62-030fa9e9a1bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "152c19d4-4f34-43fb-bd39-b0e3fbcb499e", "AQAAAAEAACcQAAAAEE31PZQdodNsiV58LYqI59irpNHOAcQr5l2qqs2xuJCgzAfhsbLoCiU6gjRZzmAitA==", "1428db4e-3f8b-4a38-b0ae-8459e26fac33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05e0023d-4657-4f86-bc95-6430bddeb44f", "AQAAAAEAACcQAAAAEDqmQGRjdpVZbv3Q8OX5ij9bQHvKtGdLS8dIBAH69k/yqe0c/bOADUTvx7pEmMzi3A==", "bff3dc0b-e2d9-43f3-bc90-b909b7caa321" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c2eea36-0017-47f9-b0e5-43fc9bed1f35", "AQAAAAEAACcQAAAAEH0zrhKMN85jzkowYp4Nsw6wOSliYqcCRaEaz/5zPQ5mzdj/1d/jJmxbPcDMT4yxaA==", "6925c539-297a-4736-87d4-7ca1a3ea13b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e26dba8a-c07a-4afa-bad0-2f69ada50606", "AQAAAAEAACcQAAAAEMLSMGAHKSxjUZIa0Q092BcQe6bwmpPq0V8+r8YeGNhHcFZViiBt3uZ3ilwQR5gH7A==", "639dd0c9-78c9-4cf9-84e4-b0ff378122c2" });
        }
    }
}
