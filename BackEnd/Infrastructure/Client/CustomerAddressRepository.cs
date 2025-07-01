using AluguelDeCarro.Domain.Entity.client;
using AluguelDeCarro.Infrastructure.Context;

namespace AluguelDeCarro.Infrastructure.Client
{
    public class CustomerAddressRepository(SqlServerDbContext context) : ICustomerAddressRepository
    {
        private readonly SqlServerDbContext _context = context;

        public void AddAddress(CustomerAddress customerAddress)
            => _context.customerAddresses.Add(customerAddress);
    }
}
