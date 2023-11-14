using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9e6a3a44-8f5c-456d-9059-5070d60a0c46", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELkD0O9WBZ3jzr395pXleD5jmsjYuhaVJOsGZsDQo9G2egSZN7gGES2D5vqf5Hfi1w==", null, false, "55ea30d9-5f15-44ad-9f36-84bb8fc488c7", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 25, 1, 49, DateTimeKind.Local).AddTicks(2398), new DateTime(2023, 11, 14, 20, 25, 1, 49, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 25, 1, 49, DateTimeKind.Local).AddTicks(2411), new DateTime(2023, 11, 14, 20, 25, 1, 49, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 25, 1, 50, DateTimeKind.Local).AddTicks(3748), new DateTime(2023, 11, 14, 20, 25, 1, 50, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 25, 1, 50, DateTimeKind.Local).AddTicks(3758), new DateTime(2023, 11, 14, 20, 25, 1, 50, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 25, 1, 51, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 11, 14, 20, 25, 1, 51, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 25, 1, 51, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 11, 14, 20, 25, 1, 51, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 25, 1, 51, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 11, 14, 20, 25, 1, 51, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 19, 18, 992, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 11, 14, 20, 19, 18, 992, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 19, 18, 992, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 11, 14, 20, 19, 18, 992, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 19, 18, 993, DateTimeKind.Local).AddTicks(8609), new DateTime(2023, 11, 14, 20, 19, 18, 993, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 19, 18, 993, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 11, 14, 20, 19, 18, 993, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8157), new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8164), new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8166), new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8166) });
        }
    }
}
