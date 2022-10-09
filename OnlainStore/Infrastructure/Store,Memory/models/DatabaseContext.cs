using Microsoft.EntityFrameworkCore;
using Store_Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Memory
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Order> Orders { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) 
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {

            new Product
            {
               Id = 1,
               Name = "Iphone 13 Pro Max",
               Cost = 125000,
               Description = "512 gb",
               Link = "/images/image1.jpg"
            },
            new Product
            {
               Id = 2,
               Name = "Sony PS5",
               Cost = 55000,
               Description = "Video game console",
               Link = "/images/image2.jpg"
            },
            new Product
            {
               Id = 3,
               Name = "War and Peace",
               Cost = 1500,
               Description = "Literary work by the Russian author Leo Tolstoy",
               Link = "/images/image3.jpg"
            },

            });
        }
    }
}
