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
        private readonly IRaiseEmployeeSalaryUseCase _raiseEmployeeSalaryUseCase;

        public EmployeesController(IRegisterEmployeeUseCase registerEmployeeUseCase,
            IRaiseEmployeeSalaryUseCase raiseEmployeeSalaryUseCase)
        {
            _registerEmployeeUseCase = registerEmployeeUseCase;
            _raiseEmployeeSalaryUseCase = raiseEmployeeSalaryUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> Post(RegisterEmployeeUseCaseInput input)
        {
            await _registerEmployeeUseCase.ExecuteAsync(input);
            return Ok();
        }

        [HttpPatch("RaiseSalary")]
        public async Task<IActionResult> RaiseSalary(RaiseEmployeeSalaryUseCaseInput input)
        {
            await _raiseEmployeeSalaryUseCase.ExecuteAsync(input);
            return Ok();
        }
    }
}
