using AluguelDeCarro.Domain.Entity.employeeLogin;
using System.Security.Cryptography;

namespace AluguelDeCarro.Infrastructure.Login
{
    public class PasswordHasher : IPasswordHasher
    {
        public byte[] GenerateSaltUser()
        {
            return RandomNumberGenerator.GetBytes(16);
        }

        public byte[] GeneratePasswordInternal(byte[] salt, string simplePassword)
        {
            using var hash = new Rfc2898DeriveBytes(simplePassword, salt, 100_000, HashAlgorithmName.SHA256);
            return hash.GetBytes(32);
        }

        public bool ValidatePasswordInternal(EmployeeLogin employee, byte[] salt, string simplePassword)
        {
            using var hash = new Rfc2898DeriveBytes(simplePassword, salt, 100_000, HashAlgorithmName.SHA256);
            byte[] result = hash.GetBytes(32);

            if (!employee.Password.SequenceEqual(result))
                return false;

            return true;
        }
    }
}
