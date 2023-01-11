using DukkanTek.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace DukkanTek.Infrastructure.Data
{
    public class DukkenTekDBContext : DbContext
    {
        public DukkenTekDBContext(DbContextOptions<DukkenTekDBContext> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().HasOne(x => x.Product)
                .WithMany(x => x.Inventory)
                .HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   CategoryId = 1,
                   CategoryName = "Biscuits",
                   CreatedById = 1,
                   CreatedDateTime= DateTime.UtcNow
               },
               new Category
               {
                   CategoryId = 2,
                   CategoryName = "Beverage",
                   CreatedById = 1,
                   CreatedDateTime = DateTime.UtcNow
               },
               new Category
               {
                   CategoryId = 3,
                   CategoryName = "Instant Food",
                   CreatedById = 1,
                   CreatedDateTime = DateTime.UtcNow
               }
               );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Britania GoodDay",
                    CategoryId = 1,
                    BarCodeText = "",
                    IsWeighted = true,
                    ProductDescription = "Britania GoodDay Biscuit",
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Monaco",
                    CategoryId = 1,
                    BarCodeText = "",
                    IsWeighted = true,
                    ProductDescription = "Parle Monaco Biscuit",
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Brokbond Tea",
                    CategoryId = 2,
                    BarCodeText = "",
                    IsWeighted = true,
                    ProductDescription = "Brokbond Strong Tea",
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Pepsi",
                    CategoryId = 2,
                    BarCodeText = "",
                    IsWeighted = true,
                    ProductDescription = "Pepsi 200 ML",
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Ching Secret Noodles",
                    CategoryId = 3,
                    BarCodeText = "",
                    IsWeighted = true,
                    ProductDescription = "Ching Secret Noodles",
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "MTR Rava Idli Mix",
                    CategoryId = 3,
                    BarCodeText = "",
                    IsWeighted = true,
                    ProductDescription = "MTR Rava Idli Mix",
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                }

                );
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory
                {
                    ItemId = 1,
                    ProductId = 1,
                    MRP = 15,
                    Discount = 0.5M,
                    PurchasePrice = 12.5M,
                    SellingPrice = 14.5M,
                    Quantity = 100,
                    Sold = 10,
                    Defective = 5,
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Inventory
                {
                    ItemId = 2,
                    ProductId = 2,
                    MRP = 10,
                    Discount = 0.5M,
                    PurchasePrice = 8.5M,
                    SellingPrice = 9.5M,
                    Quantity = 100,
                    Sold = 5,
                    Defective = 0,
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Inventory
                {
                    ItemId = 3,
                    ProductId = 3,
                    MRP = 50,
                    Discount = 0,
                    PurchasePrice = 45,
                    SellingPrice = 50,
                    Quantity = 50,
                    Sold = 20,
                    Defective = 1,
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Inventory
                {
                    ItemId = 4,
                    ProductId = 4,
                    MRP = 40,
                    Discount = 2,
                    PurchasePrice = 30,
                    SellingPrice = 38,
                    Quantity = 500,
                    Sold = 150,
                    Defective = 25,
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Inventory
                {
                    ItemId = 5,
                    ProductId = 5,
                    MRP = 25,
                    Discount = 0,
                    PurchasePrice = 19,
                    SellingPrice = 25,
                    Quantity = 500,
                    Sold = 200,
                    Defective = 70,
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                },
                new Inventory
                {
                    ItemId = 6,
                    ProductId = 6,
                    MRP = 75,
                    Discount = 10,
                    PurchasePrice = 60,
                    SellingPrice = 65,
                    Quantity = 500,
                    Sold = 200,
                    Defective = 15,
                    CreatedById = 1,
                    CreatedDateTime = DateTime.UtcNow
                }
                );
        }
    }
}