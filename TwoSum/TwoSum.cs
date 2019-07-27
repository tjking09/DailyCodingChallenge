using System;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class TwoSum
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Array.Sort(nums);
            int first = 0;
            int last = nums.Length - 1;

            while (first < last)
            {
                int n1 = nums[first];
                int n2 = nums[last];

                int sum = n1 + n2;

                if (sum > target)
                {
                    last--;
                }
                else if (sum < target)
                {
                    first++;
                }
                else
                {
                    Console.WriteLine($"Target and sum match! {nums[first]} and {nums[last]} equal {target}");
                    Console.ReadLine();
                }
            }
        }
    }
}