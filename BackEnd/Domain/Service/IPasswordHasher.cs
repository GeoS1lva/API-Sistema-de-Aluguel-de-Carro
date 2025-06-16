using AluguelDeCarro.Domain.Entity;

namespace AluguelDeCarro.Domain.Service
{
    public interface IPasswordHasher
    {
        public byte[] GenerateSaltUser();
        public byte[] GeneratePasswordInternal(byte[] salt, string simplePassword);
        public bool ValidatePasswordInternal(EmployeeLogin employee, byte[] salt, string simplePassword);
    }
}
