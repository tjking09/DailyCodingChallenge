using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            bool answer = FindDuplicate(input);

            Console.WriteLine($"{answer}");
            Console.ReadLine();

        }

        static Boolean FindDuplicate(int[] input)
        {
            Hashtable table = new Hashtable();
            foreach (int n in input)
            {
                if (table.ContainsKey(n))
                {
                    return true;
                }
                else
                {
                    table.Add(n, 0);
                }
            }

            return false;
        }
    }
}
