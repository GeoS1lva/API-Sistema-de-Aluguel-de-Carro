using AluguelDeCarro.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarro.Infrastructure.Context
{
    public class SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : DbContext(options)
    {
        public DbSet<EmployeeLogin> employeeLogins { get; set; }
    }
}
