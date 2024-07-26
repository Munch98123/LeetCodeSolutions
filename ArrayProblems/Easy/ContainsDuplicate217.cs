using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy_Problems
{
    public static class ContainsDuplicate217
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            //brute force method, check every value against every other value, time complexity n^2
            /*for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }*/

            //Optimized Solution, checks values against a HashSet of values that have been found in the array, returns true if duplicate value has been found, n complexity
            HashSet<int> seenValues = new HashSet<int>();

            foreach (var val in nums)
            {
                if (seenValues.Contains(val))
                {
                    return true;
                }
                seenValues.Add(val);
            }
            return false;
        }
    }
}
