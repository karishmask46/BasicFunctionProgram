using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram
{
    internal class FlipCoin
    {
        public void FlipCoin_Percentage()
        {
            int Heads = 0;
            int Tails = 0;

            Console.WriteLine("Enter the number of times you want to flip the coin");
            int Number_of_Flips = Convert.ToInt32(Console.ReadLine());
            while (Number_of_Flips <= 0)

            {
                Console.WriteLine("Invalid input,Please give a number greater than 0.");
                Console.Write("Please enter again: ");
                Number_of_Flips = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Number_of_Flips; i++)
            {
                Random flip = new Random();
                int HoT = flip.Next(0, 2);
                if (HoT < 0.5)
                {
                    Heads++;
                }
                else
                {
                    Tails++;
                }
            }

            float Heads_present = (float)Heads * 100 / Number_of_Flips;

            float Tails_Present = (float)Tails * 100 / Number_of_Flips;

            Console.WriteLine(Heads_present + "% of the times the result was heads .");
            Console.WriteLine(Tails_Present + "% of the times the result was tails .");

        }
    }
}
