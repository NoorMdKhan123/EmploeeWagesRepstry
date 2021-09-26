using System;

namespace EmpWagePartTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant
            int empFullTime = 1;
            int empPartTime = 2;
            int empWagePerHour = 20;

            //variable
            int empWage = 0;
            int empHr = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if(empCheck == empFullTime)
            {
                empHr = 15;
            }
            else if(empCheck == empPartTime)
            {
                empHr = 8;
            }
            else
            {
                empWage = 0;
            }
            empWage = empHr * empWagePerHour;
            Console.WriteLine("Emploayee wage of a day is : " + empWage);
        }
    }
}
