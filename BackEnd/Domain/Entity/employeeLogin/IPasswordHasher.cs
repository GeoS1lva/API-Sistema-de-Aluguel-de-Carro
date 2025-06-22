namespace AluguelDeCarro.Domain.Entity.employeeLogin
{
    public interface IPasswordHasher
    {
        public byte[] GenerateSaltUser();
        public byte[] GeneratePasswordInternal(byte[] salt, string simplePassword);
        public bool ValidatePasswordInternal(EmployeeLogin employee, byte[] salt, string simplePassword);
    }
}
