using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDay9
{
     class Program
    {
        public const int IS_PART_TIME = 1;          //Instance variable
        public const int IS_FULL_TIME = 2;          //Instance variable declared
       

        public static int ComputeEMpWage(string company,int empRatePerHour,int numofWorkingdays,int maxHourPerMonth)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingdays = 0;
            while(totalEmpHrs<=maxHourPerMonth && totalWorkingdays<numofWorkingdays)
            {
                totalWorkingdays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case IS_PART_TIME: empHrs=4; break;
                        case IS_FULL_TIME:empHrs = 8;break;
                    default:empHrs = 0;break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:"+totalWorkingdays+"Emp Hrs:"+empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company:"+company +" is:"+totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEMpWage("DMart", 20, 2, 10);
            ComputeEMpWage("Reliance", 10, 4, 20);
            ComputeEMpWage("Infosys", 60, 9, 8);
            Console.ReadLine();
        }
    }
}
