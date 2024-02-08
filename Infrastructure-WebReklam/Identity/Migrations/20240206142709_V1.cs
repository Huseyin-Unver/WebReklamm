using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_WebReklam.Identity.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3569982-6bcc-49ed-b599-6b67ae72d134",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "62aab436-601d-4948-97ea-53d6b60e3ba6", new DateTime(2024, 2, 6, 17, 27, 9, 539, DateTimeKind.Local).AddTicks(8449), "AQAAAAIAAYagAAAAEG5hY8U4kR1UkGYb7AhZ8A+j0D+NkhQnhzcfE83yMAMN4/Gw7UfFPrl0jitmtIba9A==", "1234567890", "1008c03c-9d9e-417b-8e93-a62e4a4ff2fd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3569982-6bcc-49ed-b599-6b67ae72d134",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "63eb465b-5cda-4157-b2bb-aca1bc304381", new DateTime(2024, 2, 1, 13, 34, 24, 766, DateTimeKind.Local).AddTicks(1900), "AQAAAAIAAYagAAAAEAhnpKdWG7rUSjq+t1chNrnj7fcGBP9mgz+akfxNV3B7cf4OFscsxHiMflEbPma2Zg==", null, "cd2be481-ff66-41e7-8e85-a5ae6f971284" });
        }
    }
}
