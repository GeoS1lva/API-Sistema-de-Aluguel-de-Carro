using AluguelDeCarro.Domain.Entity;

namespace AluguelDeCarro.Infrastructure.Login
{
    public interface IEmployeeLoginRepository
    {
        public void AddUser(EmployeeLogin employee);
        public Task<EmployeeLogin?> ReceiveUser(string userName);
        public Task SaveChangesAsync();
    }
}
