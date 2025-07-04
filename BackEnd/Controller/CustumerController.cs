using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Application.UseCase.ClientUC;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarro.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustumerController(ICustumerUseCase custumerUseCase) : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCustumer([FromBody] RegisterCustomer custumer)
        {
            var result = await custumerUseCase.RegisterCustomers(custumer);

            if (result.Error)
                return BadRequest(result.ErrorMessage);

            return Ok(result);
        }
    }
}
