using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBalanceTester
{
    class Program
    {
        static void Main(string[] args)

       {
                string end = null;
                while (end != "exit")
                {
                    Console.WriteLine("Welcome to the balance string checker.");
                    Console.WriteLine("Enter a string of only x's and y's and we will tell you if it is balanced.");
                    Console.Write("Your string:");
                    string checker = Console.ReadLine();

                    char[] characters = checker.ToCharArray();
                    int xs = 0;
                    int ys = 0;

                    foreach (char x in characters)
                    {
                        if (x == 'x')
                            xs++;
                    }
                    foreach (char y in characters)
                    {
                        if (y == 'y')
                            ys++;
                    }

                    if (xs % ys == 0)
                        Console.WriteLine($"\n These characters are perfectly balanced! You have {xs} Xs and {ys} Ys.");
                    else
                        Console.WriteLine($"\n These characters are NOT perfectly balanced! You have {xs} Xs and {ys} Ys.");

                    Console.WriteLine("\n\n Type exit to leave, or press enter to restart.");
                    end = Console.ReadLine();
                }
            }
        }
    }
