using System;

namespace ProblemsOnEmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HR = 20;
            int empHr = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHr = 8;
            else
                empHr = 0;

            empWage = empHr * EMP_RATE_PER_HR;
            Console.WriteLine("The DailyWage of Employee is :" + empWage);

        }
    }
}
