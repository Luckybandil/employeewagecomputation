using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEmpWageComp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Program"); 
            WageComputation EmployeeWage = new WageComputation();
            EmployeeWage.Attendance();
            Console.ReadKey();
        }

    }
}