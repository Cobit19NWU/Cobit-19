using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class AuditorClassesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "815fb694-8e84-4536-9c31-41282c5b1137");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "97c6c679-4aa9-4b05-b0f9-189b5482d516");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c1bf11c7-ddb5-4443-8689-9f1d08c43d47", "Governance Auditor", " GOVERNANCE AUDITOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "04dc90dd-ab96-4554-865b-809d26b185c7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a", "b21e841b-f84d-428c-b6bf-7b3aa2fd1791", "Management Auditor", "MANAGEMENT AUDITOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29f66ed6-86b6-4039-aa57-c26f564820ca", "AQAAAAEAACcQAAAAEFnQIYaQm/4wmarmcZZ0veB3lhYkXpMTv1luKommTfOhuqib0F0q19LeKPOlAQPO0A==", "e88c8af8-e9a6-460d-8c11-f1cf69210a03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f496b0db-03a5-4d6a-975b-78df4d0efa00", "AQAAAAEAACcQAAAAELRM3VjoXXVRFqGGoLB5mnMAJ3AaPUIO0DW8wTppyEx54vTult7x9/x5Vnm5Z7dJfA==", "55334d6e-0b2e-4c90-91ec-f06fb8f4b8ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c64c2926-b828-4e4d-9afe-8ea64d219f4c", "AQAAAAEAACcQAAAAECfy0/zlgb3Xc37PzxD86ASLqXLr/N47FvZOPaox1hhAymwcpRaTUKyd909jbiCEuw==", "2e1fb2b3-3475-4ec5-8f24-2dfbfe6537ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cebd5b1f-92a7-4b1a-9e19-7b71cae2fe92", "AQAAAAEAACcQAAAAECLTWYbpwrb50kAmpb/MM3hK9JGgUwmRp3xytpzaK+yQEx5IHC7+eKTjnIhlDY09OQ==", "41f5a5bc-fd87-4f33-9e2e-f622cc82cf29" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d", 0, "d8f2855a-2106-41d3-b507-4b3ac0411656", "emma.davis@example.com", true, "Emma", "Davis", false, null, null, "EMMA.DAVIS@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ2+G7TgmEy3dIK4qYaZQZB3zhBe7+J41vmmVeoyoPVTxFY4of6bAsuWGkgBRHH+Zg==", null, false, "d0522ee8-7163-4d50-a573-23ec3149ba16", false, "emma.davis@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a", "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d" });

            migrationBuilder.InsertData(
                table: "AuditMembers",
                columns: new[] { "ApplicationUserID", "AuditID" },
                values: new object[] { "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d", 1 });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "ApplicationUserID", "FocusAreaID" },
                values: new object[] { "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a", "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d" });

            migrationBuilder.DeleteData(
                table: "AuditMembers",
                keyColumns: new[] { "ApplicationUserID", "AuditID" },
                keyValues: new object[] { "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d", 1 });

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumns: new[] { "ApplicationUserID", "FocusAreaID" },
                keyValues: new object[] { "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d", 1 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23abcf2-58f5-4c9b-9ef7-984a1d6a7c7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-9c8d-0e9f0a1b2c3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c4c8ea90-e572-4453-998a-4a828d99d8a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "7feaaf18-2c62-461e-ba1c-50163d4e1211");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "179d3662-4988-46dc-80a8-0e7a206f9ecb", "Auditor", "AUDITOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "bb2155b2-67e4-4a47-91cb-50b9c6e70b62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b7b801a-6f59-455b-8295-5a187ed389c7", "AQAAAAEAACcQAAAAEBfJMsP3abmN0TDzeNq5/aJkkZKLsHt1p3GjboD5SnTt/7YDNFA5rZdehtmXqNNXfQ==", "db3949ac-71bb-4582-accc-0b5130904ce9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eb20c24-421d-4ddc-847d-da9bed2cdc84", "AQAAAAEAACcQAAAAEFGeumw4LPTUioRwrDyN2CZY3y2ckH4FkjT0sHSWAmgq7Xh5R8D9Wbrw3QqpFvqhog==", "63c1fad9-81b2-4597-9bc4-bfa85977e45e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4301aee3-3b52-4ee6-8248-5d0b02d8b585", "AQAAAAEAACcQAAAAEO6+8YEn7Ld+VXhb5j6wrtZ6Z53oA7G/j3ueoKi54WlhprAi3RTnHM4spXhIeIf3eg==", "4fb26f6e-b82c-44a8-8050-12a4e5d50975" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc9818d5-18e5-4afe-b458-e34db9025068", "AQAAAAEAACcQAAAAEPGMu5OWx/eoQzE/2FAdGj0l4sOmS1ZpRoOF9fsanzF/HDOZNEjyG4iDt4hd2Oi0HA==", "ea2baed8-634c-4860-8475-ee02f1463a16" });
        }
    }
}
