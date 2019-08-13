using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string strReverse = "My name is Tyler King";

            string answer = ReverseString(strReverse);

            Console.WriteLine($"{strReverse}");
            Console.WriteLine($"{answer}");
            Console.ReadLine();
        }

        static string ReverseString(string strReverse)
        {
            char[] charArray = strReverse.ToCharArray();

            for (int i = 0; i < strReverse.Length/2; i++)
            {
                char first = charArray[i];
                char temp = charArray[strReverse.Length - i - 1];
                charArray[i] = temp;
                charArray[strReverse.Length - i - 1] = first;
            }

            string s = new string(charArray);
            return s;

        }
    }
}
