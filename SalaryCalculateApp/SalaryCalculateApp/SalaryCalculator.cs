using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculateApp
{
    class SalaryCalculator
    {
        public string name;
        public string salary;


        public double CalculateSalary(double basicAmount, double houseRent, double medicalAllowance)
        {
           return basicAmount + (houseRent*0.01) + (medicalAllowance*0.01)
            ;


        }

    }
}
