using Microsoft.EntityFrameworkCore;
using Store;
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
            Database.EnsureCreated();
        }

        
    }
}
