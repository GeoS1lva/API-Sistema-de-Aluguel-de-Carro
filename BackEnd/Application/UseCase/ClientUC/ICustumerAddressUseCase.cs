using AluguelDeCarro.Application.RequestModel;

namespace AluguelDeCarro.Application.UseCase.ClientUC
{
    public interface ICustumerAddressUseCase
    {
        public Task<AddressModel> httpClientAddress(string cep);
    }
}
