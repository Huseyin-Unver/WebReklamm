using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure_WebReklam.Identity.Migrations
{
    /// <inheritdoc />
    public partial class İnitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2941c96f-580d-4fa1-a18f-80dc158b28cb", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[] { "e3569982-6bcc-49ed-b599-6b67ae72d134", 0, "b66273cf-d712-4df6-8b88-cc2a0906faad", new DateTime(2024, 2, 1, 13, 22, 44, 537, DateTimeKind.Local).AddTicks(5742), null, "admin@admin.com", false, "Admin", "Admin", true, null, "ADMIN@ADMİN.COM", "ADMIN", "AQAAAAIAAYagAAAAEDNo4amxFM/o0G/vpwL7XMvpbGHlS376HZdWQGUL8h/HKV94O1+n4JDeC6Mggmx59Q==", null, false, "3713bae5-012e-4176-88ec-e13178752ad1", 1, false, null, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2941c96f-580d-4fa1-a18f-80dc158b28cb", "e3569982-6bcc-49ed-b599-6b67ae72d134" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2941c96f-580d-4fa1-a18f-80dc158b28cb", "e3569982-6bcc-49ed-b599-6b67ae72d134" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2941c96f-580d-4fa1-a18f-80dc158b28cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3569982-6bcc-49ed-b599-6b67ae72d134");
        }
    }
}
