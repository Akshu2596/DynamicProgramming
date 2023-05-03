using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    public class KnapsackRecursion
    {
        static int max(int a, int b) { return (a > b) ? a : b; }
        //via recursion
        public int Knapsack(int[] wt, int[] val, int W, int n)
        {
            //Base condition
            if (n == 0 || W == 0)
            {
                return 0;
            }
            //choice diagram implementation
            if (wt[n - 1] <= W)
            {
                return max((val[n - 1] + Knapsack(wt, val, W - wt[n - 1], n - 1)), Knapsack(wt, val, W, n - 1));
            }
            else
                return Knapsack(wt, val, W, n - 1);
        }
    }
}
