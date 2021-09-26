using System;

namespace EmpWageCalOnCondtn
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant
            const int empFullTime = 1;
            const int empPartTime = 2;
            const int empWagePerHour = 20;
            const int noWorkingDays = 20;
            const int maxWorkingHours = 100;


            //variable
            int empHr;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpWage;

            while (totalEmpHrs <= maxWorkingHours && totalWorkingDays < noWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)

                {
                    case empFullTime:
                        empHr = 15;
                        break;

                    case empPartTime:
                        empHr = 8;
                        break;

                    default:
                        empHr = 0;
                        break;
                }
                totalEmpHrs += empHr;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + totalEmpHrs);
            }
            totalEmpWage = totalEmpHrs * empWagePerHour;
            Console.WriteLine("Employee wage of a month" + totalEmpWage);
        }
    }
}




