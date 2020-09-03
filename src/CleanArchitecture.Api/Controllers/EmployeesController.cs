using CleanArchitecture.Application.UseCases.EmployeeUseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRegisterEmployeeUseCase _registerEmployeeUseCase;

        public EmployeesController(IRegisterEmployeeUseCase registerEmployeeUseCase)
        {
            _registerEmployeeUseCase = registerEmployeeUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> Post(RegisterEmployeeUseCaseInput employee)
        {
            await _registerEmployeeUseCase.ExecuteAsync(employee);

            return Ok();
        }
    }
}
