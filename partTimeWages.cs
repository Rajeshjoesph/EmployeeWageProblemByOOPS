using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePartTimeWage
{
    internal class partTimeWages
    {
        public static void employeeWage()
        {
            const byte FULL_TIME = 2;
            const byte PART_TIME = 1;
            byte workHour = 0, wagesPerHour = 20;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0,3);
            string status;

            switch (empCheck)
            {
                case PART_TIME:
                    workHour = 1;
                    status = "Part Time";
                    break;
                case FULL_TIME:
                    workHour = 2;
                    status = "Full Time";
                    break;
                default:
                    workHour = 0;
                    status = "Absent";
                        break;
            }
            empWage = workHour * wagesPerHour;
            Console.WriteLine("Employee "+ status + " Wages :" + empWage);

        }
    }
}
