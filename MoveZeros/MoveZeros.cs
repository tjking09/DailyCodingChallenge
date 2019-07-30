// Given an array nums, 
// write a function to move all 0's to the end of it 
// while maintaining the relative order of the non-zero elements.

using System;
using System.Collections.Generic;

namespace MoveZeros
{
    class MoveZeros
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            List<int> ans = new List<int>();

            int numZeros = 0;
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    numZeros++;
                }
                else
                {
                    ans.Add(nums[i]);
                    j++;
                }
            }

            for (int k = 0; k < nums.Length; k++)
            {
                if (k < ans.Count)
                {
                    nums[k] = ans[k];
                }
                else
                {
                    nums[k] = 0;
                }
            }

            Console.WriteLine();
        }
    }
}
