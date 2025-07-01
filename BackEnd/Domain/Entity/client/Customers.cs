namespace AluguelDeCarro.Domain.Entity.client
{
    public class Customers(string name, string cpf, DateOnly dateOfBirth, string email, string telephone, TypeOfPerson typeOfPerson) : EntityBase
    {
        public string Name { get; private set; } = name;
        public string CPF { get; private set; } = cpf;
        public DateOnly DateOfBirth { get; private set; } = dateOfBirth;
        public string Email { get; private set; } = email;
        public string Telephone { get; private set; } = telephone;
        public TypeOfPerson TypeOfPerson { get; private set; } = typeOfPerson;
        public DateOnly RegistrationDate { get; private set; } = DateOnly.FromDateTime(DateTime.Now);
        public bool Status { get; private set; } = true;

        public CustomerAddress CustomerAddress { get; set; }

    }
}
