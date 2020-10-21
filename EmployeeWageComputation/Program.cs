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

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants 
            const int IS_EMPLOYEE_FULL_TIME = 1;
            const int EMP_RATE_PER_HOUR = 20;

            //Variable
            int employeeHours = 0;

            //Checks if employee is present, if present adds 8 employeehours
            //message, if employee not present adds 0 employeehours 
            if (EmployeePresent() == IS_EMPLOYEE_FULL_TIME)
            {
                employeeHours = 8;
            }
            else
            {
                employeeHours = 0;
            }

            //If employee is present calculates wage as per 8 hours. 
            Console.WriteLine("Employee Wage is" + employeeHours * EMP_RATE_PER_HOUR);
        }
        /// <summary>
        /// Method to checks whether employee is  present or not
        /// </summary>
        public static int EmployeePresent()
        {
            //Create reference of random class
            Random random = new Random();
            //Returns random value
            return random.Next(0, 2);
        }

    }
}
