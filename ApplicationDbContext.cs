using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet <Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Sales Database;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property("Name")
                .HasColumnType("varchar(50)")
                 .IsUnicode(true);
            modelBuilder.Entity<Product>()
                .Property("Quantity");
            modelBuilder.Entity<Customer>()
                .Property("Name")
                .HasColumnType("varchar(100)")
                .IsUnicode(true);
            modelBuilder.Entity<Customer>()
               .Property("Email")
               .HasColumnType("varchar(80)")
               .IsUnicode(false);
            modelBuilder.Entity<Store>()
                .Property("Name")
                .HasColumnType("varchar(80)")
                .IsUnicode(true);
           






        }
    }
}
