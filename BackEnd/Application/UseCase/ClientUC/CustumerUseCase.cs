using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Application.Validators;
using AluguelDeCarro.Domain.Entity.client;
using AluguelDeCarro.Infrastructure;

namespace AluguelDeCarro.Application.UseCase.ClientUC
{
    public class CustumerUseCase(IUnitOfWork unitOfWork) : ICustumerUseCase
    {
        public async Task<ResultModel> RegisterCustomers(RegisterCustomer customer)
        {
            if (!ValidateName.Name(customer.Name))
                return new ResultModel("É necessário nome e sobrenome");

            if(!ValidateCPF.CPF(customer.CPF))
               return new ResultModel("CPF Invalido");

            if(!ValidateDateOfBirth.DateOfBirth(customer.DateOfBirth))
                return new ResultModel("O Cliente precisa ter mais de 18 anos");

            if(!ValidateEmail.Email(customer.Email))
                return new ResultModel("E-mail inválido");

            if (customer.Telephone.Length < 11)
                return new ResultModel("O Numero precisa conter DDD e 9");

            var newCustomer = CustomersMapper.CustomersToDTO(customer);
            unitOfWork.CustomersRepository.AddCustomer(newCustomer);

            var addressNewCustomer = CustomersMapper.CustomerAddressToDTO(customer, newCustomer.id);
            unitOfWork.CustomerAddressRepository.AddAddress(addressNewCustomer);

            await unitOfWork.SaveChangesAsync();

            return new ResultModel(customer);
        }
    }
}
