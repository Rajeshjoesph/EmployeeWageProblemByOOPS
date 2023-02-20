using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaliyWages
{
    internal class EmployeeWage
    {
        public static void dayWages()
        {
            byte FULL_TIME = 1;
            byte wagesPerHour = 20, workHour = 0;
            int empWage;
            string status;
            Random random = new Random();
            int empCheck = random.Next(0,2);

            if(empCheck == FULL_TIME)
            {
                workHour = 8;
            }
            else
            {
                workHour = 0;
            }

            empWage = workHour * wagesPerHour;
            Console.WriteLine("Employee daily wages: " + empWage);
        }
    }
}
