using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium_Problems
{
    public static class ProductOfArray
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            //Brute Force, get products for every value not including itself, time complexity n^2
            /*int n = nums.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int product = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        product *= nums[j];
                    }
                }
                result[i] = product;
            }*/

            //Optimized Approach, keep track of the product of the left side of an indice and the right side of an indice and then get the product of those two values, time complexity n
            int num = nums.Length;
            int[] results = new int[num];

            //left side array
            results[0] = 1;
            for(int i = 1; i < num; i++)
            {
                results[i] = results[i - 1] * nums[i - 1];
            }

            //right side array
            int rightSideProduct = 1;
            for(int i = num - 1; i >= 0; i--)
            {
                results[i] *= rightSideProduct;
                rightSideProduct *= nums[i];
            }

            return results;
        }
    }
}
