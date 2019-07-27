/*  
 *  Write a program that outputs the string representation of numbers from 1 to n.
 *   
 *  But for multiples of three it should output “Fizz” instead of the number and 
 *  for the multiples of five output “Buzz”. 
 *  For numbers which are multiples of both three and five output “FizzBuzz”.
*/

using System;
using System.Xml.Linq;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i = 1;
            int numberCheck = 0;
            while (i <= n)
            {
                if ((numberCheck == i % 3) && (numberCheck != i % 5))
                {
                    Console.WriteLine("Fizz");
                    i++;
                }
                else if ((numberCheck == i % 5) && (numberCheck != i % 3))
                {
                    Console.WriteLine("Buzz");
                    i++;
                }
                else if ((true) && (numberCheck == i % 3) && (numberCheck == i % 5))
                {
                    Console.WriteLine("FizzBuzz");
                    i++;
                }
                else
                {
                    Console.WriteLine($"{i}");
                    i++;
                }
            }

            Console.ReadLine();
        }
    }
}
