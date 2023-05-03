using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    public class KnapsackMemoization
    {
        static int max(int a, int b) { return (a > b) ? a : b; }
        //via recursion
        public int Knapsack(int[] wt, int[] val, int W, int n)
        {
            //initialise the table
            int[,] t = new int[n + 1, W + 1];

            //fill entire table with -1
            for (int i = 0; i < n + 1; i++)
                for (int j = 0; j < W + 1; j++)
                    t[i, j] = -1;

            //Base condition
            if (n == 0 || W == 0)
            {
                return 0;
            }
            if (t[n, W] != -1)
                return t[n, W];
            //choice diagram implementation
            if (wt[n - 1] <= W)
            {
                return t[n, W] = max((val[n - 1] + Knapsack(wt, val, W - wt[n - 1], n - 1)), Knapsack(wt, val, W, n - 1));

            }
            else
                return t[n, W] = Knapsack(wt, val, W, n - 1);
        }
    }
}
