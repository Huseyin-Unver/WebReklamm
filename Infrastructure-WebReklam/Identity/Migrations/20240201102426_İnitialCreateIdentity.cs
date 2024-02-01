using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_WebReklam.Identity.Migrations
{
    /// <inheritdoc />
    public partial class İnitialCreateIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3569982-6bcc-49ed-b599-6b67ae72d134",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f41159b-d6f2-4f4d-b962-58c898326d89", new DateTime(2024, 2, 1, 13, 24, 25, 923, DateTimeKind.Local).AddTicks(1465), "AQAAAAIAAYagAAAAENCeHPpepW7SITHJaqFPCozBI6f4NBiYJalaj0EzBK9TA+aG7GZqCF35QUe/ZNqFFg==", "f19edc95-9a5b-4e06-8397-fec85d7ea163" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3569982-6bcc-49ed-b599-6b67ae72d134",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b66273cf-d712-4df6-8b88-cc2a0906faad", new DateTime(2024, 2, 1, 13, 22, 44, 537, DateTimeKind.Local).AddTicks(5742), "AQAAAAIAAYagAAAAEDNo4amxFM/o0G/vpwL7XMvpbGHlS376HZdWQGUL8h/HKV94O1+n4JDeC6Mggmx59Q==", "3713bae5-012e-4176-88ec-e13178752ad1" });
        }
    }
}
