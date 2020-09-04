using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Aggregates.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        Task<Employee> Get(string id);

        Task AddAsync(Employee employee);

        Task UpdateAsync(Employee employee);
    }
}
