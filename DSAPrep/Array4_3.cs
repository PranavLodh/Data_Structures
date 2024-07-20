using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array4_3
    {
        //Problem Statement: You are given an array of ‘N’ integers.
        //You need to find the length of the longest sequence which contains the consecutive elements.
        public static int getLongestConsecutiveSequence(int[] array)
        {
            Array.Sort(array);
            int count = 0;
            int maxcount = 0;
            int currentelement = -2;
            for(int i = 0; i < array.Length; i++) 
            {
                if ( array[i] ==  currentelement + 1 )
                {
                    count++;                    
                }
                else
                {
                    if(count > maxcount)
                        maxcount = count;
                    count = 1;
                }
                currentelement = array[i];
            }
            return maxcount;
        }
    }
}
