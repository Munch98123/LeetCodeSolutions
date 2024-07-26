using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DPProblems.Easy
{
    public class ClimbingStairs70
    {
        public static int ClimbStairs(int numberOfSteps)
        {
            if (numberOfSteps <= 2)
            {
                return numberOfSteps;
            }

            int[] stepsEncountered = new int[numberOfSteps + 1];
            stepsEncountered[1] = 1;
            stepsEncountered[2] = 2;

            for (int i = 3; i <= numberOfSteps; i++)
            {
                stepsEncountered[i] = stepsEncountered[i - 1] + stepsEncountered[i - 2];
            }

            return stepsEncountered[numberOfSteps];
        }
    }
}
