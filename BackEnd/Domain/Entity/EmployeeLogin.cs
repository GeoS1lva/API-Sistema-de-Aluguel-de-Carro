namespace AluguelDeCarro.Domain.Entity
{
    public class EmployeeLogin(string user, byte[] password, byte[] salt) : EntityBase
    {
        public string User { get; set; } = user;
        public byte[] Password { get; set; } = password;
        public byte[] Salt { get; set; } = salt;
    }
}
