/******************************************************************************
 *  Purpose: Employee Wage Computation.
 *
 *  @author  Chetan
 *  @version 1.0
 *  @since   21-10-2020
 *
 ******************************************************************************/
using EmployeeWageComputation;
using System;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeWage
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EmployeeWageBuilder apple = new EmployeeWageBuilder("Apple", 50, 20, 100);
            EmployeeWageBuilder google = new EmployeeWageBuilder("Google", 60, 20, 110);
            apple.ComputeEmployeeWage();
            Console.WriteLine(apple.toString());
            google.ComputeEmployeeWage();
            Console.WriteLine(google.toString());
        }
        
        
    }
}