/******************************************************************************
 *  Purpose: Employee Wage Computation.
 *
 *  @author  Chetan
 *  @version 1.0
 *  @since   21-10-2020
 *
 ******************************************************************************/
using System;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeWage
{
    class Program
    {
        //Constants 
        const int IS_EMPLOYEE_FULL_TIME = 1;
        const int IS_EMPLOYEE_PART_TIME = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Employee wage: " + ComputeEmployeeWage("Apple", 50, 20, 100));
            Console.WriteLine("Employee wage: " + ComputeEmployeeWage("Google", 60, 22, 100));
        }
        /// <summary>
        /// Computes the employee wage.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="employeeRatePerHour">The employee rate per hour.</param>
        /// <param name="numberOfWorkingDays">The number of working days.</param>
        /// <param name="maxHrsInMonth">The maximum HRS in month.</param>
        /// <returns></returns>
        public static int ComputeEmployeeWage(string companyName, int employeeRatePerHour, int numberOfWorkingDays, int maxHrsInMonth)
        {
            //Variable
            int employeeHours = 0;
            int totalEmployeeHours = 0;
            int totalWorkingDays = 0;

            while (totalEmployeeHours < maxHrsInMonth && totalWorkingDays < numberOfWorkingDays)
            {
                //Create reference of random class
                Random random = new Random();
                
                totalWorkingDays++;

                //Switchcase to check fulltime and part time.
                switch (random.Next(0, 3))
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
                totalEmployeeHours += employeeHours;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs: " +employeeHours);
            }
            //Calculates employee wage and returns it.
            return employeeHours * employeeRatePerHour * numberOfWorkingDays;
        }
    }
}