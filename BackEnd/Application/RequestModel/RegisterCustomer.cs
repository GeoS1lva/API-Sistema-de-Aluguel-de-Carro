using AluguelDeCarro.Domain.Entity.client;

namespace AluguelDeCarro.Application.RequestModel
{
    public class RegisterCustomer
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public TypeOfPerson TypeOfPerson { get; set; }
        public string NumberAddress { get; set; }
        public AddressType addressType { get; set; }

        public AddressModel addressModel { get; set; }
    }
}
