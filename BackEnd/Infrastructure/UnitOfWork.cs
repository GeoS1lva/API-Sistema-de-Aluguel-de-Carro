using AluguelDeCarro.Domain.Entity.cars;
using AluguelDeCarro.Domain.Entity.client;
using AluguelDeCarro.Domain.Entity.employeeLogin;
using AluguelDeCarro.Domain.Repository;
using AluguelDeCarro.Infrastructure.Client;
using AluguelDeCarro.Infrastructure.Context;
using AluguelDeCarro.Infrastructure.Login;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarro.Infrastructure
{
    public class UnitOfWork(SqlServerDbContext context) : IUnitOfWork
    {
        public ICarsRepository CarsRepository { get; } = new CarsRepository(context);
        public IEmployeeLoginRepository EmployeeLoginRepository { get; } = new EmployeeLoginRepository(context);
        public ICepRepository CepRepository { get; } = new CepRepository();
        public ICustomersRepository CustomersRepository { get; } = new CustomersRepository(context);
        public ICustomerAddressRepository CustomerAddressRepository { get; } = new CustomerAddressRepository(context);

        public async Task SaveChangesAsync()
            => await context.SaveChangesAsync();
    }
}
