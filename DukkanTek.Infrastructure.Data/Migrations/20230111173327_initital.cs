using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DukkanTek.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class initital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarCodeText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsWeighted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    MRP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: false),
                    Defective = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Inventory_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "CreatedById", "CreatedDateTime" },
                values: new object[,]
                {
                    { 1, "Biscuits", 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5324) },
                    { 2, "Beverage", 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5326) },
                    { 3, "Instant Food", 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5327) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "BarCodeText", "CategoryId", "CreatedById", "CreatedDateTime", "IsWeighted", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, "", 1, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5401), true, "Britania GoodDay Biscuit", "Britania GoodDay" },
                    { 2, "", 1, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5402), true, "Parle Monaco Biscuit", "Monaco" },
                    { 3, "", 2, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5403), true, "Brokbond Strong Tea", "Brokbond Tea" },
                    { 4, "", 2, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5404), true, "Pepsi 200 ML", "Pepsi" },
                    { 5, "", 3, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5404), true, "Ching Secret Noodles", "Ching Secret Noodles" },
                    { 6, "", 3, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5405), true, "MTR Rava Idli Mix", "MTR Rava Idli Mix" }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "ItemId", "CreatedById", "CreatedDateTime", "Defective", "Discount", "MRP", "ProductId", "PurchasePrice", "Quantity", "SellingPrice", "Sold" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5420), 5, 0.5m, 15m, 1, 12.5m, 100, 14.5m, 10 },
                    { 2, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5421), 0, 0.5m, 10m, 2, 8.5m, 100, 9.5m, 5 },
                    { 3, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5423), 1, 0m, 50m, 3, 45m, 50, 50m, 20 },
                    { 4, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5424), 25, 2m, 40m, 4, 30m, 500, 38m, 150 },
                    { 5, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5425), 70, 0m, 25m, 5, 19m, 500, 25m, 200 },
                    { 6, 1, new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5426), 15, 10m, 75m, 6, 60m, 500, 65m, 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductId",
                table: "Inventory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
