namespace AluguelDeCarro.Domain.Entity.client
{
    public interface ICustomersRepository
    {
        public void AddCustomer(Customers customers);
        public Task<bool> CheckByCPF(string cpf);
    }
}
