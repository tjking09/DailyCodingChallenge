using System;

namespace CashRegister
{
    class CashRegister
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-- Welcome to change to coins calculator --");
            //Console.Write("Enter the amount of change to give back: ");
            //string change = Console.ReadLine();
            int money_back = 93;

            int[] coins = { 25, 10, 5, 1 };
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;
            int sum = money_back;

            while (sum != 0) {
                if (coins[0] <= sum)
                {
                    sum -= coins[0];
                    quarters++;
                }
                else if (coins[1] <= sum)
                {
                    sum -= coins[1];
                    dimes++;
                }
                 else if (coins[2] <= sum)
                {
                    sum -= coins[2];
                    nickels++;
                }
                else
                {
                    sum -= coins[3];
                    pennies++;
                }
            }

            Console.WriteLine($"Quarters: {quarters}, Dimes: {dimes}, Nickels: {nickels}, Pennies: {pennies}");
            Console.ReadLine();
        }
    }
}
