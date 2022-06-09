using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram
{
    internal class Even_odd
    {
        public void evenOdd()
        {
            int num1, num2;
            Console.Write("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = num1 % 2;
            if (num2 == 0)
            {
                Console.WriteLine("{0} is an even Number.", num1);
            }
            else
            {
                Console.WriteLine("{0} is an odd Number.", num1);
            }
        }
    }
}
