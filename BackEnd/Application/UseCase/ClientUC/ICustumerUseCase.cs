using AluguelDeCarro.Application.RequestModel;

namespace AluguelDeCarro.Application.UseCase.ClientUC
{
    public interface ICustumerUseCase
    {
        public Task<ResultModel> RegisterCustomers(RegisterCustomer customer);
    }
}
