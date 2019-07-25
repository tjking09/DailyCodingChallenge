using System;

namespace TaxBracketCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            string end = null;

            while (end != "exit")
            {
                Console.WriteLine("-- Welcome to the tax owe calculator --");
                Console.Write("\n Enter your yearly income to determine how much tax you will owe: ");
                string income = Console.ReadLine();
                double tax = TaxCalc(income);
                Console.WriteLine($"\n Your tax would be: {tax}");
                Console.WriteLine("Type exit if you want to close, if not press enter to continue...");
                end = Console.ReadLine();
            }
        }

        static double TaxCalc(string x)
        {
            double answer = 0;

            double y = Convert.ToDouble(x);

            double incomeCapLvl1 = 10000;
            double incomeCapLvl2 = 30000;
            double incomeCapLvl3 = 100000;

            if (y <= incomeCapLvl1)
            {
                return answer = y * 0.0;
            }
            else if (y <= incomeCapLvl2 && y > incomeCapLvl1)
            {
                return answer = Math.Floor((y - incomeCapLvl1) * 0.10);
            }
            else if (y <= incomeCapLvl3 && y > incomeCapLvl2)
            {
                return answer = Math.Floor((y - incomeCapLvl2) * 0.25);
            }
            else
            {
                return answer = Math.Floor((y - incomeCapLvl3) * 0.40);
            }
        }
    }
}
