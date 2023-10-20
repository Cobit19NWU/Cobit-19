using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserAuditObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAuditObject",
                table: "ObjectiveAudits",
                type: "varchar(MAX)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "9a2e9d9e-bb89-4972-a607-3a478fb3f7da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "bc601e1e-7fdf-4ff1-9a15-9cb9d2d932f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "828ca82d-8220-486b-b00e-241f8584c74c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "95f4e0e6-80e7-45ec-a719-f63b6d1baa79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3216aca0-773f-4642-a1dd-ea407f7502bb", "AQAAAAEAACcQAAAAECmtttCtPOx65WS0Wn+BeqzUrn8/TlxL95jCdTOyOKf2VGu8dnYvyEUHz0b7+yC6mw==", "7376398f-829e-4b7e-955c-160873df5b70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6227b693-ae1c-4090-b9a4-a1a20e873cc0", "AQAAAAEAACcQAAAAEOLM4a1eytGX+VDqFupjJqpyBeNglNKB2JYfHoeiktK4zSKHH2X/WOcRSz2jaWFdNQ==", "e3fa83ad-95bf-4575-a814-ddf1d1460445" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34ac70fd-8c3f-4faa-a788-a4f5cde9ee27", "AQAAAAEAACcQAAAAECmM/ZTStc7UfO0uBd0HxWcxH2MXMl1NtlQZj47hUTVbFf/MHDuY97uq8u/ZsHV/sw==", "f73dd8fb-963e-466f-ab17-5dee4f06a96f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb6eeea3-e855-4083-9c03-9801d4de0254", "AQAAAAEAACcQAAAAEOdFv1i+jIy8kajHbs6fIpi96+NYXRXFFtX0J58kE4lYpHX6TU+QPNwsQ72ztnJOIw==", "96fe0742-2588-404a-8e67-679627df7faf" });

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 1,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 2,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 3,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 4,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 5,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 6,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 7,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 8,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 9,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 10,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 11,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 12,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 13,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 14,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 15,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 16,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 17,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 18,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 19,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 20,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 21,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 22,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 23,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 24,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 25,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 26,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 27,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 28,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 29,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 30,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 31,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 32,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 33,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 34,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 35,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 36,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 37,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 38,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 39,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 40,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 41,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 42,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 43,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 44,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 45,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 46,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 47,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 48,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 49,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 50,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 51,
                column: "UserAuditObject",
                value: null);

            migrationBuilder.UpdateData(
                table: "ObjectiveAudits",
                keyColumn: "ID",
                keyValue: 52,
                column: "UserAuditObject",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAuditObject",
                table: "ObjectiveAudits");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "217b9a7c-13b2-4287-ae3b-10bbc684614c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "c815a3a4-1d44-476e-9cfd-3403422d086c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "245eda66-68ff-456c-b67c-fc06045ebd06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "1feb5893-bb12-4b90-bf3d-b717ec220dad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4fd3774-9ad9-4499-a218-282229970bd0", "AQAAAAEAACcQAAAAEMoNKKQGDNEbpgVj+KyXk3YYQW12k3oEwA2iqgiSGyKxQwcEbOigzIpYv9QnGYfxmQ==", "dc8bd217-eb94-4329-aa52-9690caa633ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285e5fb9-f729-4930-a1ba-1c64ebde4b31", "AQAAAAEAACcQAAAAELWbHQwjnB2E2LbNh4LxeNFFy+Xb6NvhBXRpG4k7SL644Oe7NsR2YL1d8OM2X6vovA==", "1e438525-1cb7-4681-a25d-9d876860e569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c82f3e47-8bcb-4a19-a7fc-da5d43b4c32d", "AQAAAAEAACcQAAAAEI84D4Jl2axyddG/nQ3gVjRr3HAh0ZEK60baAngBs1VIU/Hp+RSJRh1JBEG6gmCfRQ==", "ebea1299-51da-4697-819a-5878a947341a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d25c1f6-8e87-4fc7-a8c3-995e8ac23e49", "AQAAAAEAACcQAAAAEOqN84f0O1wkNMEyEdDQw5dNDcJCrIMqrBMr/I/EQBCr9sOzAUQ//nZCB/D+UMrMbA==", "a6e4cf38-edac-49c2-96e4-5ac5184b72e9" });
        }
    }
}
