using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy_Problems
{
    public static class TwoSum
    {
        //indices will be returned as a list of ints
        public static int[] GetTwoSum(int[] nums, int target)
        {
            //Brute Force Solution (n^2) time
            /*for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Check if the sum of the current pair equals the target
                    if (nums[i] + nums[j] == target)
                    {
                        // If found, return the indices of the two elements
                        return new int[] { i, j };
                    }
                }
            }*/

            //Optimized Solution using Dictionary
            // Create a dictionary to store the numbers and their indices
            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement of the current number
                int complement = target - nums[i];

                // Check if the complement exists in the hash map
                if (resultDictionary.ContainsKey(complement))
                {
                    // If found, return the indices of the current number and its complement
                    return new int[] { resultDictionary[complement], i };
                }

                // Add the current number and its index to the hash map
                resultDictionary[nums[i]] = i;
            }

            return new int[] { };
        }
    }
}
