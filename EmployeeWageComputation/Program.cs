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
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_WORKING_HOURS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Employee wage: " + ComputeEmployeeWage());
        }
        public static int ComputeEmployeeWage()
        {
            //Variable
            int employeeHours = 0;
            int totalEmployeeHours = 0;
            int totalWorkingDays = 0;

            while (totalEmployeeHours < MAX_WORKING_HOURS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
            return employeeHours * EMP_RATE_PER_HOUR * NUM_OF_WORKING_DAYS;
        }
    }
}