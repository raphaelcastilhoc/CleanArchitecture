using CleanArchitecture.Domain.SeedWork;
using System;

namespace CleanArchitecture.Domain.Aggregates.EmployeeAggregate
{
    public class Employee : Entity, IAggregateRoot
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }

        public decimal Salary { get; private set; }

        public void RaiseSalary(decimal salary)
        {
            if(salary <= Salary)
            {
                throw new InvalidOperationException("Salary must be greater than current salary");
            }

            Salary = salary;
        }
    }
}
