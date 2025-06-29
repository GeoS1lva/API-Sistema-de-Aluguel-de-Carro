using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Application.UseCase.CarsUC;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarro.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController(ICarsUseCase carsUseCase) : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> RegisterNewCar([FromBody] RegisterCar newCar)
        {
            var result = await carsUseCase.RegisterCar(newCar);

            if (result.Error)
                return BadRequest(result.ErrorMessage);

            return Ok(result.Value);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteCar(string licensePlace)
        {
            var result = await carsUseCase.DeleteCar(licensePlace);

            if (result.Error)
                return BadRequest(result.ErrorMessage);

            return Ok(result.Value);
        }
    }
}
