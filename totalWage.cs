using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class totalWage
    {
        public static void wages()
        {
            const byte PART_TIME = 1;
            const byte FULL_TIME = 2;
            const byte MAX_WORK_MONTH = 10;
            byte WORK_DAYS = 20;
            int workHour = 0,totHours=0,totDays=0, totWage = 0,wagesPerHour=20;
            while(workHour <= WORK_DAYS && totDays <= MAX_WORK_MONTH)
            {
                totDays++;
                Random random = new Random();
                int empCheck=random.Next(0,3);
                switch(empCheck)
                {
                    case PART_TIME:
                        workHour=4;
                        break;
                    case FULL_TIME:
                        workHour = 8;
                        break;
                    default:
                        workHour = 0;
                        break;

                }
                totHours=totHours+workHour;
                
            }
            totWage = totHours * wagesPerHour;
            Console.WriteLine("Employee Total Working Hours: " + totHours);
            Console.WriteLine("Employee Total Working Days: " + totDays);
            Console.WriteLine("Employee Total wages: " + totWage);
        }
    }
}
