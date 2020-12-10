using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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

            ChangeTracker.StateChanged += (o, args) => {
                if (args.NewState == EntityState.Deleted && 
                    (args.Entry.Entity is Product || args.Entry.Entity is User))
                {
                    var id = args.Entry.CurrentValues.GetValue<Guid>("Id");

                    var entityNAme = args.Entry.CurrentValues.EntityType.DisplayName();

                    SensitiveDataDeleted.Invoke(id, entityNAme);
                }
            };
        }

        public delegate void SensitiveDataDeletedHandler (Guid id, string entityName);
        public static event SensitiveDataDeletedHandler  SensitiveDataDeleted;

        public DbSet<User> Users { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BuyerProduct> BuyerProducts { get; set; }
        public DbSet<SensitiveData> DeletedSensitiveData { get; set; }
        public DbSet<SignInInfo> SignInInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>().HasKey(b => b.Id);
            modelBuilder.Entity<Buyer>().HasMany(b => b.BuyerProducts);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Seller>().HasKey(s => s.Id);
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<BuyerProduct>()
                .HasKey(bp => new { bp.BuyerId, bp.ProductId });
            modelBuilder.Entity<SignInInfo>().HasNoKey();
        }



    }
}
