using System;

namespace ProblemsOnEmployeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;

        public static int ComputeEmployeeWage()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int hrs = 0;
            int workingDays = 1;
            Random random = new Random();
            while (hrs < MAX_WORKING_HRS && workingDays <= MAX_WORKING_DAYS)
            {
                workingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWage = EMP_RATE_PER_HOUR * empHrs;
                hrs += empHrs;
                totalEmpWage = totalEmpWage + empWage;
            }
            Console.WriteLine("Employe Wage Per Day:" + empWage);
            Console.WriteLine("Total Employe Month Wage: " + totalEmpWage);
            Console.WriteLine("Employee wage for " + workingDays + "Days " + totalEmpWage);
            Console.WriteLine("Working hours " + hrs);
            return totalEmpWage;
        }
        public static void Main(String[] args)
        {
            Program.ComputeEmployeeWage();

        }
}
}
