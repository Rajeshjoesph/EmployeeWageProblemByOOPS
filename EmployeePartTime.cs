using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTimeWages
{
    internal class EmployeePartTime
    {
        public static void partTime()
        {
            byte FULL_TIME = 2, PART_TIME = 1;
            byte wagesPerHour = 20,workHour=0;
            int empWage = 0;
            Random random=new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck==PART_TIME)
            {
                workHour = 4;
            }
            else if(empCheck==FULL_TIME)
            {
                workHour = 8;
            }
            else
            {
                workHour = 0;
            }
            empWage=wagesPerHour*workHour;
            Console.WriteLine("Employee Wages: " + empWage);

        }
    }
}
