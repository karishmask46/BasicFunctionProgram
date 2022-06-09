using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram
{
    internal class Quotient_Remainder
    {
        public void CompQuotient()
        {
            Console.WriteLine("enter a number1 : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number2 :");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Quotient = Num1 / Num2;
            int Remainder = Num1 % Num2;

            Console.WriteLine("quotient=" + Quotient);
            Console.WriteLine("remainder = " + Remainder);
            Console.ReadLine();
        }
    }
}

