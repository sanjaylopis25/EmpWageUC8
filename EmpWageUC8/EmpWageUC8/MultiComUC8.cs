using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageUC8
{
    public class MultiComUC8
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        
        public static int computeEmpWage(string company,int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day No:" + totalWorkingDays + " Employee Hours:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage :" + totalEmpWage);
            return totalEmpWage;
        }
    }
}

