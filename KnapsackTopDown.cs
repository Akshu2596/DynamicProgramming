using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    public class KnapsackTopDown
    {
        public int Knapsack(int[] wt, int[] val, int W, int n)
        {
            //initialise a table
            int[,] t = new int[n + 1, W + 1];
            //Base Condition
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    if (i == 0 || j == 0)
                        t[i, j] = 0;
                    //choice diagram inplementation in iterative manner
                    else if (wt[i - 1] <= j)
                        t[i, j] = Math.Max((val[i - 1] + t[i - 1, j - wt[i - 1]]), t[i - 1, j]);
                    else
                        t[i, j] = t[i - 1, j];

                }
            }
            return t[n, W];

        }
    }
}
