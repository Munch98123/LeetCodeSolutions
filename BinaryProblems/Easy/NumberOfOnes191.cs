using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BinaryProblems.Easy
{
    public class NumberOfOnes191
    {
        public static int GetOnesBruteForce(int n)
        {
            //Brute force method involves checking every bit by &ing the value to 1
            int count = 0;
            //ints max out at 32 bits
            for(int i = 0; i < 32; i++)
            {
                if((n & 1) == 1)
                {
                    count++;
                }
                n >>= 1;
            }
            return count;
        }

        public static int GetOnesOptimized(int n)
        {
            //recursively determines how many ones are in the number
            return n == 0 ? 0 : (n & 1) + GetOnesOptimized(n >> 1);
        }
    }
}
