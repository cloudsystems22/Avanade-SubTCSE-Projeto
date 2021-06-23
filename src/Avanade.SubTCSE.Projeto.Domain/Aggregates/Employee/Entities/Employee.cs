using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities
{

    public record Employee : BaseEntity<string>
    {
        public Employee(
            string firstName, 
            string surname, 
            DateTime birth, 
            bool active, 
            decimal salary, 
            EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            FirstName = firstName;
            Surname = surname;
            Birth = birth;
            Active = active;
            Salary = salary;
            this.employeeRole = employeeRole;
        }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime Birth { get; set; }

        public bool Active { get; set; }

        public decimal Salary { get; set; }

        public EmployeeRole.Entities.EmployeeRole employeeRole { get; init; }
    }
}
