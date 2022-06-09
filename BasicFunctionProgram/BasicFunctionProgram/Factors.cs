using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram
{
    internal class Factors
    {
        public void PrimeFactors()
        {
            Console.WriteLine("enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prime factors of {0} are : ", number);

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
