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
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            EmployeeBuilderArray employeeBuilderArray = new EmployeeBuilderArray();
            employeeBuilderArray.AddCompanyEmpWage("Apple", 50, 20, 100);
            employeeBuilderArray.AddCompanyEmpWage("Google", 60, 20, 110);
            employeeBuilderArray.ComputeEmpWage();
        }
    }
}