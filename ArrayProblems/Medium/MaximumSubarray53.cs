using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium_Problems
{
    public class MaximumSubarray53
    {
        public static int MaxSubarrayKadanes(int[] nums)
        {
            //Kadanes Algorithm, most used with n time complexity
            int currentMax = nums[0];
            int globalMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentMax = Math.Max(nums[i], currentMax + nums[i]);
                if (currentMax > globalMax)
                {
                    globalMax = currentMax;
                }
            }

            return globalMax;
        }

        public int MaxSubArrayBruteForce(int[] nums)
        {
            //Brute Force, nested for loop checking every other value for every value, n^2
            int maxSum = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentSum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    currentSum += nums[j];
                    maxSum = Math.Max(maxSum, currentSum);
                }
            }

            return maxSum;
        }

        public int MaxSubArrayDivideAndConquer(int[] nums)
        {
            //recursive divide and conquer, checks left side array, right side array, and cross-section array, nlogn time complexity
            return MaxSubArrayDivideAndConquerHelper(nums, 0, nums.Length - 1);
        }

        private int MaxSubArrayDivideAndConquerHelper(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return nums[left];
            }

            int mid = (left + right) / 2;
            int leftSum = MaxSubArrayDivideAndConquerHelper(nums, left, mid);
            int rightSum = MaxSubArrayDivideAndConquerHelper(nums, mid + 1, right);
            int crossSum = CrossMaxSum(nums, left, right, mid);

            return Math.Max(Math.Max(leftSum, rightSum), crossSum);
        }

        private int CrossMaxSum(int[] nums, int left, int right, int mid)
        {
            int leftSubsum = int.MinValue;
            int currSum = 0;
            for (int i = mid; i >= left; i--)
            {
                currSum += nums[i];
                leftSubsum = Math.Max(leftSubsum, currSum);
            }

            int rightSubsum = int.MinValue;
            currSum = 0;
            for (int i = mid + 1; i <= right; i++)
            {
                currSum += nums[i];
                rightSubsum = Math.Max(rightSubsum, currSum);
            }

            return leftSubsum + rightSubsum;
        }
    }
}
