using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ClsEmployees
    {

        public ClsEmployees()
        {
            Name = "";
            DailySalary = 0.0m;
            Age = 0;
        }

        public string Name;

        public decimal DailySalary;

        public int Age;

        public decimal CalculateSalary(int NumOfDays)
        {
            return DailySalary * NumOfDays;
        }
    }
}
