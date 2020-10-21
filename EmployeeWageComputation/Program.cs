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
        static void Main(string[] args)
        {
            //Constants 
            const int IS_EMPLOYEE_FULL_TIME = 1;
            const int IS_EMPLOYEE_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HOURS_IN_MONTH = 100;
            //Variable
            int employeeHours = 0, totalEmployeeHours = 0, totalWorkingDays = 0;

            while (totalEmployeeHours <= MAX_WORKING_HOURS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                //Create reference of random class
                Random random = new Random();
                //Returns random value
                int employeeCheck = random.Next(0, 2);
                totalWorkingDays++;

                //Switchcase to check fulltime and part time.
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
                totalEmployeeHours += employeeHours;                
                Console.WriteLine("Days: " + totalWorkingDays + "Employee per hour" + employeeHours);
            }
            int totalEmployeeWage = employeeHours * EMP_RATE_PER_HOUR * NUM_OF_WORKING_DAYS;
            Console.WriteLine("Employee wage is: " + totalEmployeeWage);
        }   
    }
}