/******************************************************************************
 *  Purpose: Employee Wage Computation.
 *
 *  @author  Chetan
 *  @version 1.0
 *  @since   21-10-2020
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants 
            const int IS_EMPLOYEE_FULL_TIME = 1;
            const int IS_EMPLOYEE_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            //Variable
            int employeeHours = 0;

            //Create reference of random class
            Random random = new Random();
            //Returns random value
            int employeeCheck = random.Next(0, 2);

            switch (employeeCheck) 
            {
                case IS_EMPLOYEE_FULL_TIME:
                    employeeHours = 8;
                    break;
                case IS_EMPLOYEE_PART_TIME:
                    employeeHours = 4;
                    break;
                default:
                    employeeHours = 0;
                    break;
            }
            int totalEmployeeWage = employeeHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Daily wage: " + totalEmployeeWage);
        }        
    }
}
