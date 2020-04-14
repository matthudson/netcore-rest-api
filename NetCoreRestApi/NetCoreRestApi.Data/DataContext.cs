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
    }
}
