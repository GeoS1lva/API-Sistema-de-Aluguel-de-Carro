using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Domain.Entity.client;

namespace AluguelDeCarro.Infrastructure.Client
{
    public class CepRepository : ICepRepository
    {
        private HttpClient _httpClient = new HttpClient();

        public async Task<AddressModel?> GetAddress(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            var response = await _httpClient.GetAsync(url);

            var address = await response.Content.ReadFromJsonAsync<AddressModel>();

            return response.IsSuccessStatusCode ? address : null;
        }
    }
}
