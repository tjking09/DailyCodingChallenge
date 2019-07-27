/*
 * Given a non-empty array of integers, every element appears twice except for one. 
 * Find that single one.
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleNumber
{
    class SingleNumber
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1 };
            var unique = new List<int>();

            foreach (int i in nums)
            {
                if (unique.Contains(i))
                {
                    unique.Remove(i);
                }
                else
                {
                    unique.Add(i);
                }
            }

            int answer = unique.First();
            Console.WriteLine($"The unique number is {answer}");
            Console.ReadLine();
        }
    }
}
