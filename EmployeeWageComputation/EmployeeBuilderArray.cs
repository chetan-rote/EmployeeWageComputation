using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeBuilderArray
    {
        //Constants 
        const int IS_EMPLOYEE_FULL_TIME = 1;
        const int IS_EMPLOYEE_PART_TIME = 2;

        //Private Variable stores number of company
        private int numOfCompany = 0;
        //Created Array
        private CompanyEmpWage[] companyEmpWageArrays;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBuilderArray"/> class.
        /// </summary>
        public EmployeeBuilderArray()
        {
            this.companyEmpWageArrays = new CompanyEmpWage[5];
        }
        /// <summary>
        /// Adds the company emp wage.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="employeeRatePerHour">The employee rate per hour.</param>
        /// <param name="numberOfWorkingDays">The number of working days.</param>
        /// <param name="maxHrsInMonth">The maximum HRS in month.</param>
        public void AddCompanyEmpWage(string companyName, int employeeRatePerHour, int numberOfWorkingDays, int maxHrsInMonth)
        {
            companyEmpWageArrays[this.numOfCompany] = new CompanyEmpWage(companyName, employeeRatePerHour, numberOfWorkingDays, maxHrsInMonth);
            numOfCompany++;
        }
        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArrays[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArrays[i]));
                Console.WriteLine(this.companyEmpWageArrays[i].PrintTotalEmployeeWage());
            }
        }
        /// <summary>
        /// Computes the employee wage.
        /// </summary>
        /// <param name="companyEmployeeWage">The company employee wage.</param>
        /// <returns></returns>
        public int ComputeEmpWage(CompanyEmpWage companyEmployeeWage)
        {
            //Variable
            int employeeHours = 0;
            int totalEmployeeHours = 0;
            int totalWorkingDays = 0;

            //While checks for the employee conditions
            while (totalEmployeeHours < companyEmployeeWage.maxHrsInMonth && totalWorkingDays < companyEmployeeWage.numberOfWorkingDays)
            {
                //Create reference of random class
                Random random = new Random();
                //increments the working days
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
                //Assigns employee hours to total employee hour.
                totalEmployeeHours += employeeHours;                
            }
            //Calculates employee wage and returns it.
            return totalEmployeeHours * companyEmployeeWage.employeeRatePerHour;      
        }
    }
}
