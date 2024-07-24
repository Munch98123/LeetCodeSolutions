using LeetCodeProblems.Easy_Problems;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two Sum
            Console.WriteLine($"--Two Sum--");
            Console.WriteLine("[ 1, 2, 3, 4, 5, 6 ]");

            Action<int> print = (element) => Console.WriteLine($"Indice {element}");
            Array.ForEach(TwoSum.GetTwoSum(new int[6] { 1, 2, 3, 4, 5, 6 }, 9), print);

            Console.WriteLine("");

            //Buy and Sell Stocks\
            Console.WriteLine("[ 7, 1, 5, 3, 6, 4 ]");

            Console.WriteLine("--Buy and Sell Stocks--");
            Console.WriteLine($"Max Profit: {BuyAndSellStock.GetMaxProfit(new int[6] { 7, 1, 5, 3, 6, 4 })}");

            Console.WriteLine($"--Contains Duplicates--");
            Console.WriteLine("[1, 2, 3, 1]");
            Console.WriteLine(ContainsDuplicate217.ContainsDuplicate(new int[4] { 1, 2, 3, 1 }));
            Console.WriteLine("");
            Console.WriteLine("[1,1,1,3,3,4,3,2,4,2]");
            Console.WriteLine(ContainsDuplicate217.ContainsDuplicate(new int[10] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }
    }
}
