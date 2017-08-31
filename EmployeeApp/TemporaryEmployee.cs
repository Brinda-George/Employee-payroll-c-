using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class TemporaryEmployee : Employee
    {
        private string _contractDate;
        private double _wagePerHour;
        private int _hoursWorked;
        private int _oT;
        public TemporaryEmployee(string Name, string ContractDate, double WagePerHour, int HoursWorked, int OT) : base(Name)
        {
            _contractDate = ContractDate;
            _wagePerHour = WagePerHour;
            _hoursWorked = HoursWorked;
            _oT = OT;
        }
        public override double CalculateSalary()
        {
            double Salary = (_hoursWorked + _oT * 2) * _wagePerHour;
            return Salary;
        }
    }
}
