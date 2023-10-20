using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DFInformationSeed4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f0db69dc-dee4-4bc3-9bbb-41de38bf9b85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7",
                column: "ConcurrencyStamp",
                value: "fb9d3a8c-f066-4079-b604-e06c4030df34");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3",
                column: "ConcurrencyStamp",
                value: "837d9971-0ce2-462b-b6bf-4276dc5aac9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295",
                column: "ConcurrencyStamp",
                value: "e2783206-a8f5-45a3-b30b-db11d81f0962");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b4881e9-0b1e-4a63-82a7-0ac3b67d0338", "AQAAAAEAACcQAAAAEFltu8FzFJRUphwHGD97YVbcrhRnPQM5fBEaz6QXP6vfnFqyNTG1wlIJkkuGdNRGRQ==", "aa2bc7f6-2593-4b01-ba6f-45d632bb2b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1a0f34-8765-4321-dcba-ba09876543c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6844365-d50a-4cf9-9b58-0224a3aa3572", "AQAAAAEAACcQAAAAECs6X345EWPAjSHgkEzs6tpyJIIqq5+6oOl6hT1TuRIWTT3P0UI979uiqlfTm5NuWA==", "e7dc2fd6-da52-4805-9415-837d84c67054" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-1234-5678-0987654321dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b92f2a9-69f5-4211-b171-4fdc21294335", "AQAAAAEAACcQAAAAEKTM8uDncCQp8Q9bSBHkgr5YA+YFp6Uknk/2xxCyFgl80eM3SXXfKh/ba/eyWXz5Yg==", "9cf9c7a1-9d90-47d9-bcc0-64682a469dc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa567c12-5678-4321-bacd-87654321de1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80f873cb-3229-48cd-9113-b941e8d2db94", "AQAAAAEAACcQAAAAEGvMWYD8h4HsJpZUMEvTtwLa/fgUDK8b1SwA05wHwQd6vJPJad95q7IvuqDnWyPQTg==", "57fd0589-05e4-4772-b681-48b72855f09e" });

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 6,
                column: "Information",
                value: "The compliance requirements to which the enterprise is subject to, can be classified according to these categories. Low compliance requirements - The enterprise is subject to a minimal set of regular compliance requirements that are lower than average. Normal compliance requirements - The enterprise is subject to a set of regular compliance requirements that are common across different industries. High compliance requirements - The enterprise is subject to higher than average compliance requirements, most often related to the industry sector or geopolitical conditions");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 7,
                column: "Information",
                value: "The role of IT for the enterprise can be classified according to the categories: Support - IT is not crucial for the running and continuity of the business process and services, nor for their innovation. Factory - When IT fails, it immediately impacts the running and continuity of the business processes and services. However, IT is not seen as a driver for innovating business processes and services. Turnaround - IT is seen as a driver for innovating business processes and services. At this moment, however, IT is not a critical dependency for the current running and continuity of the business processes and services.");

            migrationBuilder.UpdateData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 8,
                column: "Information",
                value: "The sourcing model the enterprise adopts can be classified according to the categories: Outsourcing - The enterprise calls upon the services of a third party to provide IT services. Cloud - The enterprise maximizes the use of the cloud for providing IT services to its users. Insourced - The enterprise provides for their own IT staff and services.");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Description", "Information" },
                values: new object[] { "Technology adoption strategy", "The methods the enterprise adopts can be classified according to the categories outlined as follows: Agile - The enterprise uses Agile development working methods for its software development. DevOps - The enterprise uses DevOps working methods for software building, deployment and operations. <strong>Traditional</strong> - The enterprise uses a more classic approach towards software development (waterfall) and separates software development and operations." });
        }
    }
}
