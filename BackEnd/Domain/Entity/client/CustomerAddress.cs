namespace AluguelDeCarro.Domain.Entity.client
{
    public class CustomerAddress(string cep, string street, string number, string neighborhood, string city, string state, AddressType addressType, int customerId) : EntityBase
    {
        public string CEP { get; private set; } = cep;
        public string Street { get; private set; } = street;
        public string Number { get; private set; } = number;
        public string Neighborhood { get; private set; } = neighborhood;
        public string City { get; private set; } = city;
        public string State { get; private set; } = state;
        public AddressType addressType { get; private set; } = addressType;

        public int CustomerId { get; private set; } = customerId;
        public Customers Customer { get; private set; }
    }
}
