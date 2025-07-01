using AluguelDeCarro.Domain.Entity.cars;
using AluguelDeCarro.Domain.Entity.client;
using AluguelDeCarro.Domain.Entity.employeeLogin;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarro.Infrastructure.Context
{
    public class SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : DbContext(options)
    {
        public DbSet<EmployeeLogin> employeeLogins { get; set; }
        public DbSet<Cars> cars { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<CustomerAddress> customerAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customers>()
                .HasOne(c => c.CustomerAddress)
                .WithOne(a => a.Customer)
                .HasForeignKey<CustomerAddress>(f => f.CustomerId);
        }
    }
}
