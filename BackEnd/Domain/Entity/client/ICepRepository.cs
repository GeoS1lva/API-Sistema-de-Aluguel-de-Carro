using AluguelDeCarro.Application.RequestModel;

namespace AluguelDeCarro.Domain.Entity.client
{
    public interface ICepRepository
    {
        public Task<AddressModel?> GetAddress(string cep);
    }
}
