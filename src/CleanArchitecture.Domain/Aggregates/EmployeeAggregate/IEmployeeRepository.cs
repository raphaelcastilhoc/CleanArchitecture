using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Aggregates.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        Task AddAsync(Employee employee);
    }
}
