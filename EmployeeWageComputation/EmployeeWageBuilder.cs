using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWageBuilder
    {
        //Constants 
        const int IS_EMPLOYEE_FULL_TIME = 1;
        const int IS_EMPLOYEE_PART_TIME = 2;

        //Variables
        private string companyName;
        private int employeeRatePerHour;
        private int numberOfWorkingDays;
        private int maxHrsInMonth;
        private int totalEmpWage;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeWageBuilder"/> class.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="employeeRatePerHour">The employee rate per hour.</param>
        /// <param name="numberOfWorkingDays">The number of working days.</param>
        /// <param name="maxHrsInMonth">The maximum HRS in month.</param>
        public EmployeeWageBuilder(string companyName, int employeeRatePerHour, int numberOfWorkingDays, int maxHrsInMonth)
        {
            this.companyName = companyName;
            this.employeeRatePerHour = employeeRatePerHour;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }

        /// <summary>
        /// Computes the employee wage.
        /// </summary>
        /// <returns></returns>
        public int ComputeEmpWage()
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
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs: " + employeeHours);
            }
            //Calculates employee wage and returns it.
            totalEmpWage = totalEmployeeHours * this.employeeRatePerHour;
            Console.WriteLine("Total Employee wage for Company: " + companyName + "is: " + totalEmpWage);
            return 0;
        }

        public string PrintTotalEmployeeWage()
        {
            return "Total Employee wage for Company: " + this.companyName + "is: " + this.totalEmpWage;
        }
    }
}
