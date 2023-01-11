﻿// <auto-generated />
using System;
using DukkanTek.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DukkanTek.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DukkenTekDBContext))]
    [Migration("20230111173327_initital")]
    partial class initital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DukkanTek.Infrastructure.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Biscuits",
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5324)
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Beverage",
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5326)
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Instant Food",
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5327)
                        });
                });

            modelBuilder.Entity("DukkanTek.Infrastructure.Data.Entities.Inventory", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Defective")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MRP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Sold")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5420),
                            Defective = 5,
                            Discount = 0.5m,
                            MRP = 15m,
                            ProductId = 1,
                            PurchasePrice = 12.5m,
                            Quantity = 100,
                            SellingPrice = 14.5m,
                            Sold = 10
                        },
                        new
                        {
                            ItemId = 2,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5421),
                            Defective = 0,
                            Discount = 0.5m,
                            MRP = 10m,
                            ProductId = 2,
                            PurchasePrice = 8.5m,
                            Quantity = 100,
                            SellingPrice = 9.5m,
                            Sold = 5
                        },
                        new
                        {
                            ItemId = 3,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5423),
                            Defective = 1,
                            Discount = 0m,
                            MRP = 50m,
                            ProductId = 3,
                            PurchasePrice = 45m,
                            Quantity = 50,
                            SellingPrice = 50m,
                            Sold = 20
                        },
                        new
                        {
                            ItemId = 4,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5424),
                            Defective = 25,
                            Discount = 2m,
                            MRP = 40m,
                            ProductId = 4,
                            PurchasePrice = 30m,
                            Quantity = 500,
                            SellingPrice = 38m,
                            Sold = 150
                        },
                        new
                        {
                            ItemId = 5,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5425),
                            Defective = 70,
                            Discount = 0m,
                            MRP = 25m,
                            ProductId = 5,
                            PurchasePrice = 19m,
                            Quantity = 500,
                            SellingPrice = 25m,
                            Sold = 200
                        },
                        new
                        {
                            ItemId = 6,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5426),
                            Defective = 15,
                            Discount = 10m,
                            MRP = 75m,
                            ProductId = 6,
                            PurchasePrice = 60m,
                            Quantity = 500,
                            SellingPrice = 65m,
                            Sold = 200
                        });
                });

            modelBuilder.Entity("DukkanTek.Infrastructure.Data.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("BarCodeText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsWeighted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BarCodeText = "",
                            CategoryId = 1,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5401),
                            IsWeighted = true,
                            ProductDescription = "Britania GoodDay Biscuit",
                            ProductName = "Britania GoodDay"
                        },
                        new
                        {
                            ProductId = 2,
                            BarCodeText = "",
                            CategoryId = 1,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5402),
                            IsWeighted = true,
                            ProductDescription = "Parle Monaco Biscuit",
                            ProductName = "Monaco"
                        },
                        new
                        {
                            ProductId = 3,
                            BarCodeText = "",
                            CategoryId = 2,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5403),
                            IsWeighted = true,
                            ProductDescription = "Brokbond Strong Tea",
                            ProductName = "Brokbond Tea"
                        },
                        new
                        {
                            ProductId = 4,
                            BarCodeText = "",
                            CategoryId = 2,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5404),
                            IsWeighted = true,
                            ProductDescription = "Pepsi 200 ML",
                            ProductName = "Pepsi"
                        },
                        new
                        {
                            ProductId = 5,
                            BarCodeText = "",
                            CategoryId = 3,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5404),
                            IsWeighted = true,
                            ProductDescription = "Ching Secret Noodles",
                            ProductName = "Ching Secret Noodles"
                        },
                        new
                        {
                            ProductId = 6,
                            BarCodeText = "",
                            CategoryId = 3,
                            CreatedById = 1,
                            CreatedDateTime = new DateTime(2023, 1, 11, 17, 33, 26, 924, DateTimeKind.Utc).AddTicks(5405),
                            IsWeighted = true,
                            ProductDescription = "MTR Rava Idli Mix",
                            ProductName = "MTR Rava Idli Mix"
                        });
                });

            modelBuilder.Entity("DukkanTek.Infrastructure.Data.Entities.Inventory", b =>
                {
                    b.HasOne("DukkanTek.Infrastructure.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DukkanTek.Infrastructure.Data.Entities.Product", b =>
                {
                    b.HasOne("DukkanTek.Infrastructure.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}