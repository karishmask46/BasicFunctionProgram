using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram
{
    internal class Power_Of_Two
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("please enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number < 0 || number >= 31)
            {
                Console.WriteLine("please enter a valid number: ");
                number = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));

            }
        }
    }
}

