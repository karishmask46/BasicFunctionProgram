using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram
{
    internal class Harmonic_number
    {
        public void Harmonic()
        {
            double Harmonic_result = 0;
            Console.WriteLine("enter the value of N for Nth harmonic;");
            int N = Convert.ToInt32(Console.ReadLine());


            for (double i = 1; i <= N; i++)
            {
                Harmonic_result += 1 / i;


            }
            Console.WriteLine("The " + N + "th Harmonic is given by " + Harmonic_result);
        }

    }
}

    

