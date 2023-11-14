using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class DefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 14, 20, 19, 18, 993, DateTimeKind.Local).AddTicks(8609), new DateTime(2023, 11, 14, 20, 19, 18, 993, DateTimeKind.Local).AddTicks(8615), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 14, 20, 19, 18, 993, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 11, 14, 20, 19, 18, 993, DateTimeKind.Local).AddTicks(8618), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8157), new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8161), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8164), new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8164), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8166), new DateTime(2023, 11, 14, 20, 19, 18, 994, DateTimeKind.Local).AddTicks(8166), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 3, 7, 827, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 11, 14, 20, 3, 7, 827, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 14, 20, 3, 7, 827, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 11, 14, 20, 3, 7, 827, DateTimeKind.Local).AddTicks(5512) });
        }
    }
}
