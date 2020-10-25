using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<BuyerProduct> BuyerProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>().HasKey(b => b.Id);
            //modelBuilder.Entity<Buyer>().HasMany(b => b.BuyerProducts).WithOne();
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Seller>().HasKey(s => s.Id);
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            //modelBuilder.Entity<BuyerProduct>().HasKey(bp => bp.Id);
        }
    }
}
