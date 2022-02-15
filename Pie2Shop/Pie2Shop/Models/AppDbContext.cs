using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed Categories
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 1, Name = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 2, Name = "Cheese Cakes" });
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 3, Name = "Seasonal pies" });

            // seed pies
            modelBuilder.Entity<Pie>().HasData(new Pie()
            {
                PieId = 1,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription =
                "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "/Images/carousel2.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie()
            {
                PieId = 2,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription =
                "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "/Images/carousel2.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie()
            {
                PieId = 3,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription =
                "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "/Images/carousel2.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie()
            {
                PieId = 4,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription =
                "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "/Images/carousel2.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie()
            {
                PieId = 5,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription =
                "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "/Images/carousel2.jpg",
                AllergyInformation = ""
            });
        }
    }
}
