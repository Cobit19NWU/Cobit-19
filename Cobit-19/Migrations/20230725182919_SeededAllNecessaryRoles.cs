using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class SeededAllNecessaryRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "e20a8a92-5224-43d7-957e-778d40192e30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7", "c4957c34-e099-4607-b30c-b118bd771543", "Head Auditor", "HEAD AUDITOR" },
                    { "5e70cf29-1b64-4f58-85dd-07b3c46015a3", "3dab4041-cbe8-498b-a805-96034ec7666c", "Auditor", "AUDITOR" },
                    { "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295", "300060e2-3366-4aae-b4b8-34b69c750836", "Client", "CLIENT" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf6b7deb-572f-47c8-8367-f0497a0b52a4", "AQAAAAEAACcQAAAAECDp6RP/5HJwwTO/SV0/NEMe11Myy1IYo5zsPHmcwM7o2JsN8Y0E4MMfHSa/HT7ivg==", "e21e7487-beb2-4a99-9552-f9aca8a6725b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "de7eca78-19e6-452c-91ba-513621f92b86");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ef4e528-6c05-416b-8eef-a3bc1eebf946", "AQAAAAEAACcQAAAAEG7gQC1BP7M3qgvKPdP21hUs86sgPF3SXABB9qC88sarJpX78fhzUk1MR8Hlrs+8EA==", "71e25299-3972-4e59-907b-7c19a3dd2735" });
        }
    }
}
