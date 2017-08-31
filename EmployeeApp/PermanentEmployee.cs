using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class PermanentEmployee : Employee
    {
        private int _pFAccountNumber;
        private int _noOfLeaves;
        private double _pay;
        public PermanentEmployee(string Name, int PFAccountNumber, int NoOfLeaves, double Pay) : base(Name)
        {
            _pFAccountNumber = PFAccountNumber;
            _noOfLeaves = NoOfLeaves;
            _pay = Pay;
        }
        public override double CalculateSalary()
        {
            double Salary = _pay * (30 - _noOfLeaves) / 30;
            return Salary;
        }
    }
}
