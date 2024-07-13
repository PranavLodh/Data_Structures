using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array6
    {
        public static int getMaxProfit(int[] a)
        {
            int buyingprice = a[0];
            int maxprofit = 0;
            int currentprofit = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i]<buyingprice)
                {
                    buyingprice = a[i];                    
                    currentprofit = 0;
                }
                else
                {
                    currentprofit = a[i] - buyingprice;
                    if (currentprofit > maxprofit)
                    {
                        maxprofit = currentprofit;
                    }
                }
            }
            return maxprofit;
        }
    }
}
