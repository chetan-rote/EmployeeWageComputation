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
            
            //Checks if employee is present, if present gives employee wage
            //message, if employee not present displays absent
            if (EmployeePresent() == IS_EMPLOYEE_FULL_TIME)
            {
                FullTimeEmployeeWage();
            }
            else
            if (EmployeePresent() == IS_EMPLOYEE_PART_TIME)
            {
                PartTimeEmployeeWage();
            }
            else
            {
                Console.WriteLine("Employee was absent");
            }
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
        /// <summary>
        /// Method to calculate Full time employee wage
        /// </summary>
        public static int FullTimeEmployeeWage()
        {
            int EMP_RATE_PER_HOUR = 20;
            int employeeHours = 8;
            //calculates wage for full time employee
            int fullTimeWage = employeeHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is " + fullTimeWage);
            return fullTimeWage;
        }
        /// <summary>
        /// Method to calculate Part time employee wage
        /// </summary>
        public static int PartTimeEmployeeWage()
        {
            int EMP_RATE_PER_HOUR = 20;
            int employeeHours = 4;
            //calculates wage for part time employee
            int partTimeWage = employeeHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is " + partTimeWage);
            return partTimeWage;            
        }
    }
}
