using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram
{
    internal class LeapYear
    {
        public void Leapyear()
        {
            Console.WriteLine("enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());
            while (year <= 1000 || year >= 9999)
            {
                Console.WriteLine("please enter a four digit number: ");
                year = Convert.ToInt32(Console.ReadLine());
            }
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))

            {
                Console.WriteLine(year + " is a leap year");

            }
            else
            {
                Console.WriteLine(year + "is not a leap year");
            }

        }
    }
}
    

