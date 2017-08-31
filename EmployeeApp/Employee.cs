using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public abstract class Employee
    {
        public string Name;
        public Employee(string Name)
        {
            this.Name = Name;
        }
        public abstract double CalculateSalary();   
    }
}
