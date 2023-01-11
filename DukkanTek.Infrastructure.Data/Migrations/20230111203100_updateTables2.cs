using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DukkanTek.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotamAmount",
                table: "Order",
                newName: "TotalAmount");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 20, 30, 59, 276, DateTimeKind.Utc).AddTicks(502));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Order",
                newName: "TotamAmount");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 18, 58, 41, 71, DateTimeKind.Utc).AddTicks(7604));
        }
    }
}
