using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DukkanTek.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 41, 58, 781, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
