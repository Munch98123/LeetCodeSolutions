using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium_Problems
{
    public class MinimumInSortedArray153
    {
        public static int FindMinBinary(int[] nums)
        {
            //uses modified binary search to look for the smallest value in logn time
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                {
                    left = mid + 1;  
                }
                else
                {
                    right = mid; 
                }
            }

            return nums[left];
        }
    }
}
