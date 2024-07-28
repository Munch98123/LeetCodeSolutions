using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BinaryProblems.Easy
{
    public static class MissingNumber268
    {
        public static int MissingNumber(int[] nums)
        {
            //calculates the number that is missing from the array
            //the criteria is that the total numbers that should be in the array are equal to the highest number in the array
            //there is one number missing however, goal is to caclulate the missing number 
            //my solution is to add up the numbers that are in the arrray and subtract that value from the total of the numbers that should be in the array
            var numsResult = 0;
            var totalResult = 0;
            Array.ForEach(nums, value => numsResult += value);
            for(int i = 1; i <= nums.Length; i++)
            {
                totalResult += i;
            }

            return totalResult - numsResult;
        }
    }
}
