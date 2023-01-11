using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DukkanTek.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class addTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    TotamAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Promo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5405));
        }
    }
}
