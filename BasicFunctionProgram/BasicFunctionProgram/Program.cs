namespace BasicFunctionProgram
{
    class functionalprogrm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.");
            Console.WriteLine("1 for a flip coin and print percentage of Heads and  Tails")
            int function = Convert.ToInt32(Console.ReadLine());



            switch (function)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoin_Percentage();
                    break;

            }
        }
    }
}
