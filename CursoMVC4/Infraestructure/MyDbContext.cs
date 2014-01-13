using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CursoMVC4.Models;

namespace CursoMVC4.Infraestructure
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("DBConnection"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.ComplexType<Address>();
            modelBuilder.Entity<Customer>().Property(m => m.Address.Line1);
            modelBuilder.Entity<Customer>().Property(m => m.Address.ZipCode);
        }

        public DbSet<Customer> Customers { get;set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}