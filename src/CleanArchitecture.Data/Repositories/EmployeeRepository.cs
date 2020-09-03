using CleanArchitecture.Domain.Aggregates.EmployeeAggregate;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace CleanArchitecture.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMongoCollection<Employee> _employees;

        public EmployeeRepository(IMongoDatabase database)
        {
            _employees = database.GetCollection<Employee>("employee");
        }

        public async Task AddAsync(Employee employee)
        {
            await _employees.InsertOneAsync(employee);
        }
    }
}
