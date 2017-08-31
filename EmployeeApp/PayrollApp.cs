using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class PayrollApp
    {
        List<Employee> employeeList = new List<Employee>();
        public void GeneratePayroll()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeList = employeeRepository.GetEmployees();
            Console.WriteLine("Report:");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee.Name + "---------" + employee.CalculateSalary());
            }
        }

}
}
