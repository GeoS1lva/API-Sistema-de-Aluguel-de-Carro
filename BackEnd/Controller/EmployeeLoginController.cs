using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Application.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarro.Controller;

[ApiController]
[Route("api/[controller]")]
public class EmployeeLoginController(IEmployeeLoginUseCase employeeLoginUseCase) : ControllerBase
{
    [HttpPost]
    [Route("CreateUser")]
    public async Task<IActionResult> CreateUser([FromBody] RequestEmployeeLogin request)
    {
        var result = await employeeLoginUseCase.CreateUser(request);

        if (result.Error)
            return BadRequest(result.ErrorMessage);

        return Ok(result);
    }

    [HttpPost]
    [Route("requestLogin")]
    public async Task<IActionResult> RequestLogin([FromBody] RequestEmployeeLogin request)
    {
        var result = await employeeLoginUseCase.RequestEmployeeLogin(request);

        if (result.Error)
            return BadRequest(result.ErrorMessage);

        return Ok(result);
    }
}
