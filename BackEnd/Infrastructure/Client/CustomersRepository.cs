using AluguelDeCarro.Domain.Entity.client;
using AluguelDeCarro.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarro.Infrastructure.Client
{
    public class CustomersRepository(SqlServerDbContext context) : ICustomersRepository
    {
        private readonly SqlServerDbContext _context = context;

        public void AddCustomer(Customers customers)
            => _context.customers.Add(customers);

        public async Task<bool> CheckByCPF(string cpf)
            => await _context.customers.AnyAsync(x => x.CPF == cpf);
    }
}
