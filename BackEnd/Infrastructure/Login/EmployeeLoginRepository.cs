using System.Runtime.InteropServices;
using AluguelDeCarro.Domain.Entity.employeeLogin;
using AluguelDeCarro.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarro.Infrastructure.Login
{
    public class EmployeeLoginRepository(SqlServerDbContext context) : IEmployeeLoginRepository
    {
        private readonly SqlServerDbContext _context = context;

        public void AddUser (EmployeeLogin employee)
        {
            _context.employeeLogins.Add(employee);
        }

        public async Task<EmployeeLogin?> ReceiveUser(string userName)
            => await _context.employeeLogins.FirstOrDefaultAsync(x => x.User == userName);

        public async Task SaveChangesAsync()
            => await _context.SaveChangesAsync();
    }
}
