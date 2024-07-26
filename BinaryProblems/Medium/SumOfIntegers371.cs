using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BinaryProblems.Medium
{
    public class SumOfIntegers371
    {
        public static int AddWithoutAddition(int a, int b)
        {
            /*
            Calculates the sum of the numbers without carrying first using XOR
            Then performs a bitwise and operation, shifting the bits to the left afterwards
            When the second number is 0 in binary then the summation is complete
             */
            while (b != 0)
            {
                int sum = a ^ b;
                int carry = (a & b) << 1;
                a = sum;
                b = carry;
            }
            return a;
        }
    }
}
