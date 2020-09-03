using CleanArchitecture.Domain.Aggregates.EmployeeAggregate;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.EmployeeUseCases
{
    public class RegisterEmployeeUseCase : IRegisterEmployeeUseCase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public RegisterEmployeeUseCase(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task ExecuteAsync(RegisterEmployeeUseCaseInput employeeInput)
        {
            var employee = new Employee(employeeInput.Name, employeeInput.Salary);
            await _employeeRepository.AddAsync(employee);
        }
    }
}
