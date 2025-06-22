using AluguelDeCarro.Domain.Entity.cars;
using AluguelDeCarro.Domain.Entity.employeeLogin;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarro.Infrastructure.Context
{
    public class SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : DbContext(options)
    {
        public DbSet<EmployeeLogin> employeeLogins { get; set; }
        public DbSet<Cars> cars { get; set; }
    }
}
