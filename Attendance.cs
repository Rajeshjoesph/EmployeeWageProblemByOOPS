using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStatus
{
    internal class Attendance
    {
        public static void Employee()
        {
            byte FULL_TIME = 1;
            int workHour = 0;
            Random random= new Random();
            int empCheck = random.Next(0,2);
            string status;
            if (FULL_TIME == empCheck)
            {
                workHour = 8;
                status = "Present";
            }
            else
            {
                workHour = 0;
                status = "Absent";
            }

            Console.WriteLine("Employee is: " + status);

        }
    }
}
