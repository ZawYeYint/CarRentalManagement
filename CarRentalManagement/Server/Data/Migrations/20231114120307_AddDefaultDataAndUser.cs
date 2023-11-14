using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 14, 20, 3, 7, 827, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 11, 14, 20, 3, 7, 827, DateTimeKind.Local).AddTicks(5510), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 14, 20, 3, 7, 827, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 11, 14, 20, 3, 7, 827, DateTimeKind.Local).AddTicks(5512), "Blue", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
