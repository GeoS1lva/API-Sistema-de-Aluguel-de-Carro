using AluguelDeCarro.Domain.Entity.cars;
using AluguelDeCarro.Domain.Entity.client;
using AluguelDeCarro.Domain.Entity.employeeLogin;

namespace AluguelDeCarro.Infrastructure
{
    public interface IUnitOfWork
    {
        public ICarsRepository CarsRepository { get; }
        public IEmployeeLoginRepository EmployeeLoginRepository { get; }
        public ICepRepository CepRepository { get; }
        public ICustomersRepository CustomersRepository { get; }
        public ICustomerAddressRepository CustomerAddressRepository { get; }

        public Task SaveChangesAsync();
    }
}
