using Microsoft.EntityFrameworkCore;
using NetCoreRestApi.Data.Models;

namespace NetCoreRestApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        
        public DbSet<CustomerRegistration> CustomerRegistrations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Policy> Policies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerRegistration>()
                .Property(s => s.Created)
                    .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Customer>()
                .HasIndex(b => b.OnlineReference)
                    .IsUnique();
            
            modelBuilder.Entity<Customer>()
                .Property(s => s.OnlineReference)
                .HasDefaultValueSql("ABS(CHECKSUM(NEWID())) % 1000000 + 1");

            modelBuilder.Entity<Customer>()
                .Property(s => s.Created)
                    .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Policy>()
                .Property(s => s.Created)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
