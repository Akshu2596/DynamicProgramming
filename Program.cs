using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Knapsack;

namespace KnapsackProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wt = { 10, 20, 30 };
            int[] val = { 60, 100, 120 };
            int W = 50;
            KnapsackRecursion rec = new KnapsackRecursion();
            int maxProfitRec = rec.Knapsack(wt, val, W, wt.Length);
            Console.WriteLine(maxProfitRec);
            KnapsackMemoization mem = new KnapsackMemoization();
            int maxProfitMem = mem.Knapsack(wt, val, W, wt.Length);
            Console.WriteLine(maxProfitMem);
            KnapsackTopDown td = new KnapsackTopDown();
            int maxProfitTd = td.Knapsack(wt, val, W, wt.Length);
            Console.WriteLine(maxProfitTd);
            Console.Read();
        }
    }
}
