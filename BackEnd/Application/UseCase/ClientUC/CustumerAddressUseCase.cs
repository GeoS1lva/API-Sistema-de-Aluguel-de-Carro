using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Infrastructure;

namespace AluguelDeCarro.Application.UseCase.ClientUC
{
    public class CustumerAddressUseCase(IUnitOfWork unitOfWork) : ICustumerAddressUseCase
    {
        public async Task<AddressModel> httpClientAddress(string cep)
        {
            if (cep.Length > 9 || cep.Length < 8)
                return null;

            var newAddress = await unitOfWork.CepRepository.GetAddress(cep);

            return newAddress;
        }
    }
}
