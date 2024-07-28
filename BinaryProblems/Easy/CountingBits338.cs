using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BinaryProblems.Easy
{
    public class CountingBits338
    {
        public static int[] GetBits(int n)
        {
            //uses Hammingweight calculation of previous problem to calculate the Hamminweight of each index
            int[] bits = new int[n+1];
            for(int i = 1; i <= n; i++)
            {
                bits[i] = NumberOfOnes191.GetOnesOptimized(i);
            }

            return bits;
        }
    }
}
