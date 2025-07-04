using AluguelDeCarro.Application.UseCase.ClientUC;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarro.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController(ICustumerAddressUseCase addressUseCase) : ControllerBase
    {
        [HttpGet]
        [Route("GetAddress")]
        public async Task<IActionResult> Address(string cep)
        {
            var result = await addressUseCase.httpClientAddress(cep);

            if (result == null)
                return BadRequest("Cep Inválido /ou endereço não encontrado!");

            return Ok(result);
        }
    }
}
