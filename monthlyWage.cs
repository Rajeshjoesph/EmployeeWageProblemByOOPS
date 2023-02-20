using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class monthlyWage
    {
        public static void Wages()
        {
            const byte FULL_TIME = 2;
            const byte PART_TIME = 1;
            byte WORK_DAYS = 20;
            byte wagePerHour = 20,workHour=0;
            int empWages = 0,totWage=0;
            string status;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case PART_TIME:
                    workHour = 1;
                    status = "PART TIME";
                    break;
                case FULL_TIME:
                    workHour = 2;
                    status = "FULL TIME";
                    break;
                default:
                    workHour = 0;
                    status = "Absent";
                    break;

            }
            empWages = workHour * wagePerHour;
            totWage = empWages * WORK_DAYS;
            Console.WriteLine("Employee " + status + " Wages: " + empWages);
            Console.WriteLine("Employee Total Wages:" + totWage);


        }
    }
}
