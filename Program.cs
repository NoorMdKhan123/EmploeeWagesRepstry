using System;

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
            
            //variable constant
            int employee = 1;
            int employeeWage = 0;
            //constant
            int employee_daily_wage_perhr = 20;
            int wrking_hr_day = 8;

            if (employee == 1)
            {
                employeeWage = employee_daily_wage_perhr * wrking_hr_day;
                Console.WriteLine("Employee wage of 8 hours is" + employeeWage);
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
