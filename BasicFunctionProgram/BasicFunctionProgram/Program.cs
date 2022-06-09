namespace BasicFunctionProgram
{
    class functionalprogrm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.");
            Console.WriteLine("1 for a flip coin and print percentage of Heads and  Tails");
            Console.WriteLine("2 for a leap year");
            Console.WriteLine("3 for a power of 2");
            Console.WriteLine("4 for a harmonic number");
            Console.WriteLine("5 for a factors");
            Console.WriteLine("6 for a Quotient and Remainder");
            Console.WriteLine("7 for a Swap Number ");
            Console.WriteLine("8 for a even and odd number ");
            int function = Convert.ToInt32(Console.ReadLine());



            switch (function)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoin_Percentage();
                    break;
               case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Leapyear();
                    break;
                case 3:
                    Power_Of_Two Power = new Power_Of_Two();
                    Power.PowerOfTwo();
                    break;
                case 4:
                    Harmonic_number harmonic = new Harmonic_number();
                    harmonic.Harmonic();
                    break;
                case 5:
                    Factors factor = new Factors();
                    factor.PrimeFactors();
                    break;
                case 6:
                    Quotient_Remainder QuotientRemain = new Quotient_Remainder();
                    QuotientRemain.CompQuotient();
                    break;
                case 7:
                    Swap_Number Swap = new Swap_Number();
                    Swap.SwapTwoNumber();
                    break;
                case 8:
                    Even_odd even = new Even_odd();
                    even.evenOdd();
                    break;


            }
        }
    }
}
