using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        //Variables
        public string companyName;
        public int employeeRatePerHour;
        public int numberOfWorkingDays;
        public int totalEmpWage;
        public int maxHrsInMonth;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEmpWage"/> class.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="employeeRatePerHour">The employee rate per hour.</param>
        /// <param name="numberOfWorkingDays">The number of working days.</param>
        /// <param name="maxHrsInMonth">The maximum HRS in month.</param>
        public CompanyEmpWage(string companyName, int employeeRatePerHour, int numberOfWorkingDays, int maxHrsInMonth)
        {
            this.companyName = companyName;
            this.employeeRatePerHour = employeeRatePerHour;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
        /// <summary>
        /// Sets the total emp wage.
        /// </summary>
        /// <param name="totalEmpWage">The total emp wage.</param>
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        /// <summary>
        /// Prints the total employee wage.
        /// </summary>
        /// <returns></returns>
        public string PrintTotalEmployeeWage()
        {
            return "Total Employee wage for Company: " + this.companyName + "is: " + this.totalEmpWage;
        }
    }    
}
