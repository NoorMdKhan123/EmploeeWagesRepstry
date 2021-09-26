using System;

namespace EmpWageofMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant
            const int empFullTime = 1;
            const int empPartTime = 2;
            const int empWagePerHour = 20;
            const int totalWorkingDays = 20;

            //variable
            int empWage = 0;
            int empHr = 0;
            int empWageofDay = 0;
        
            for (int day = 0; day <= totalWorkingDays; day++)
            {
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


                empWage = empHr * empWagePerHour;
                empWageofDay += empWage;
                Console.WriteLine("Emploayee wage of a day is : " + empWage);
            }
       
            Console.WriteLine("Employee wage of a month" + empWageofDay);
        }
    }
}
