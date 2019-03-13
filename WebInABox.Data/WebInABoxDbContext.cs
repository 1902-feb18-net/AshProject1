using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebInABox.Core;

namespace WebInABox.Data
{
    public class WebInABoxDbContext : DbContext
    {
        public WebInABoxDbContext(DbContextOptions<WebInABoxDbContext> options)
            :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public DbSet<Statistics> Statistics { get; set; }

        //added method below to establish foreign key for Order class
        //protected override void OnModelCreating(ModelBuilder modelbuilder)
        //{
        //    modelbuilder.Entity<Order>()
        //        .HasKey(o => new { o.Customer, o.Product });
        //}


    }
}
