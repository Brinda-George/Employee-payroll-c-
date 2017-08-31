using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class EmployeeRepository
    {
        List<Employee> employeeList = new List<Employee>();
        public EmployeeRepository()
        {
        }
        public List<Employee> GetEmployees()
        {
            employeeList.Add(new PermanentEmployee("brinda", 53456345, 2, 300000));
            employeeList.Add(new PermanentEmployee("meenu", 12326, 5, 300000));
            employeeList.Add(new PermanentEmployee("anju", 809806, 7, 300000));
            employeeList.Add(new PermanentEmployee("linda", 972867, 3, 300000));
            employeeList.Add(new PermanentEmployee("alex", 3456786, 6, 300000));
            employeeList.Add(new PermanentEmployee("john", 673498, 4, 300000));
            employeeList.Add(new TemporaryEmployee("george", "12/08/2017", 500.00, 40, 20));
            employeeList.Add(new TemporaryEmployee("anu", "08/03/2017", 600.00, 40, 20));
            employeeList.Add(new TemporaryEmployee("jacob", "02/04/2017", 500.00, 40, 20));
            employeeList.Add(new TemporaryEmployee("kukku", "30/01/2017", 700.00, 40, 20));
            employeeList.Add(new TemporaryEmployee("joseph", "24/06/2017", 800.00, 40, 20));
            return employeeList;
        }
    }
}
