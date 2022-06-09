using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram
{
    internal class Vowel_Consonant
    {
        public void vowConsonant()
        {
            char Alpha;
            Console.WriteLine("Enter a Alphabet:");
            Alpha = Convert.ToChar(Console.ReadLine().ToLower());
            int y = Alpha;
            switch (Alpha)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is a Vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is a Vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is a Vowel");
                    break;

                case 'o':
                    Console.WriteLine("The Alphabet is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is a Vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a Vowel");
                    break;
            }
            Console.ReadKey();
        }
    }
}

