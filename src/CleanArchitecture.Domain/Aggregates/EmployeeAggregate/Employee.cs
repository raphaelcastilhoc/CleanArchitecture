using System;

namespace CleanArchitecture.Domain.Aggregates.EmployeeAggregate
{
    public class Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public decimal Salary { get; private set; }
    }
}
