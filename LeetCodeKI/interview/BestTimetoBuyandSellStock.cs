using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
    public class BestTimetoBuyandSellStock
    {
        //суть уловил, но реализовал не особо по умному, примерное время решение c обдумыванием ~30 минут
        public static int MaxProfit(int[] prices)
        {
            //var toSell = (prices[0], 0);
            //var toBuy = (prices[0], 0);
            //var answer = 0;
            //for (int i = 1; i < prices.Length; i++)
            //{

            //    if (toSell.Item1 < prices[i])
            //    {
            //        toSell.Item1 = prices[i];
            //        toSell.Item2 = i;
            //    }

            //    if (toBuy.Item2 < toSell.Item2)
            //    {
            //        var result = toSell.Item1 - toBuy.Item1;
            //        answer = result > answer ? result : answer;
            //    }

            //    if (toBuy.Item1 > prices[i])
            //    {
            //        toBuy.Item1 = prices[i];
            //        toBuy.Item2 = i;
            //        toSell.Item1 = prices[i];
            //    }
            //}

            //return answer;

            int max = 0;
            int min = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }

                else if ((prices[i] - min) > max)
                {
                    max = prices[i] - min;
                }
            }
            return max;
        }

        //best solution

    }
}
