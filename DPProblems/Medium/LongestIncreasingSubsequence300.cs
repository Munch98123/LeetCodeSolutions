using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DPProblems.Medium
{
    public class LongestIncreasingSubsequence300
    {
        public static int GetLongestSubsequence(int[] nums)
        {
            List<int> currentSequence = new List<int>();
            List<int> longestSequence = new List<int>();

            currentSequence.Add(nums[0]);

            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    currentSequence.Add(nums[i]);
                }
                else if (nums[i] < nums[i - 1])
                {

                }
            }

            return int.MaxValue;
        }
    }
}
