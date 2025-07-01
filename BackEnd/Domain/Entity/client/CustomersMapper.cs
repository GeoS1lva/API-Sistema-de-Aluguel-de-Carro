using AluguelDeCarro.Application.RequestModel;

namespace AluguelDeCarro.Domain.Entity.client
{
    public class CustomersMapper
    {
        public static Customers CustomersToDTO(RegisterCustomer registerCustomer)
        {
            return new Customers(
                registerCustomer.Name,
                registerCustomer.CPF,
                registerCustomer.DateOfBirth,
                registerCustomer.Email,
                registerCustomer.Telephone,
                registerCustomer.TypeOfPerson
            );
        }

        public static CustomerAddress CustomerAddressToDTO(RegisterCustomer registerCustomer)
        {
            return new CustomerAddress(
                registerCustomer.addressModel.cep,
                registerCustomer.addressModel.logradouro,
                registerCustomer.NumberAddress,
                registerCustomer.addressModel.bairro,
                registerCustomer.addressModel.localidade,
                registerCustomer.addressModel.uf,
                registerCustomer.addressType,
                registerCustomer.CustomerId
            );
        }
    }
}
