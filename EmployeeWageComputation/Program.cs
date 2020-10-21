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
        public static void Main(string[] args)
        {
            //Constants
            const int IS_EMPLOYEE_FULL_TIME = 1;
            const int EMP_RATE_PER_HOUR = 20;

            //Variable
            int employeeHours = 0;

            //Checks if employee is present, if present give Employee Present
            //message, if employee not present will  give Absent message 
            if (EmployeePresent() == IS_EMPLOYEE_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            /// <summary>
            /// Method to checks whether employee is  present or not
            /// </summary>
            static int EmployeePresent()
            {
                //Create reference of random class
                Random random = new Random();
                //Returns random value
                return random.Next(0, 2);
            }



        }
    }
}
