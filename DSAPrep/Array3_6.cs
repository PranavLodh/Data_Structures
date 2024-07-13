using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array3_6
    {
        public static int countReversePairs(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                for(int j = i; j < array.Length; j++)
                {
                    if (array[i] > 2 * array[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
