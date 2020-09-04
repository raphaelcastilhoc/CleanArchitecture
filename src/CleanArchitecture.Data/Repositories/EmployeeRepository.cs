using CleanArchitecture.Domain.Aggregates.EmployeeAggregate;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IMongoDatabase database) 
            : base(database, "employees")
        {
        }

        public async Task<IEnumerable<Employee>> GetAsync()
        {
            var employees = await _collection.Find(_ => true).ToListAsync();
            return employees;
        }

        public async Task<Employee> GetAsync(string id)
        {
            var employee = await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return employee;
        }

        public async Task AddAsync(Employee employee)
        {
            await _collection.InsertOneAsync(employee);
        }

        public async Task UpdateAsync(Employee employee)
        {
            await _collection.ReplaceOneAsync(x => x.Id == employee.Id, employee, new ReplaceOptions { IsUpsert = true });
        }
    }
}
