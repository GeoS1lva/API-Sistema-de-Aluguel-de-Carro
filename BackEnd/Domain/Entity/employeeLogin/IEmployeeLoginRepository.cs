namespace AluguelDeCarro.Domain.Entity.employeeLogin
{
    public interface IEmployeeLoginRepository
    {
        public void AddUser(EmployeeLogin employee);
        public Task<EmployeeLogin?> ReceiveUser(string userName);
        public Task SaveChangesAsync();
    }
}
