using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_WebReklam.Identity.Migrations
{
    /// <inheritdoc />
    public partial class IdentityMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3569982-6bcc-49ed-b599-6b67ae72d134",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63eb465b-5cda-4157-b2bb-aca1bc304381", new DateTime(2024, 2, 1, 13, 34, 24, 766, DateTimeKind.Local).AddTicks(1900), "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEAhnpKdWG7rUSjq+t1chNrnj7fcGBP9mgz+akfxNV3B7cf4OFscsxHiMflEbPma2Zg==", "cd2be481-ff66-41e7-8e85-a5ae6f971284" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3569982-6bcc-49ed-b599-6b67ae72d134",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f41159b-d6f2-4f4d-b962-58c898326d89", new DateTime(2024, 2, 1, 13, 24, 25, 923, DateTimeKind.Local).AddTicks(1465), "ADMIN", "AQAAAAIAAYagAAAAENCeHPpepW7SITHJaqFPCozBI6f4NBiYJalaj0EzBK9TA+aG7GZqCF35QUe/ZNqFFg==", "f19edc95-9a5b-4e06-8397-fec85d7ea163" });
        }
    }
}
