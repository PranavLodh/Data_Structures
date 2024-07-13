using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given an array of N integers, write a program to return an element that occurs more
    //than N/2 times in the given array.
    //You may consider that such an element always exists in the array.
    internal class Array3_3
    {        
        public static int CalculateMostOccurring(int[] a)
        {
            int target = a.Length / 2;
            Dictionary<int, int> mydict = new Dictionary<int, int>();
            foreach (int i in a) 
            {
                if (mydict.ContainsKey(i))
                {
                    mydict[i]++;                    
                }
                else
                {
                    mydict.Add(i, 1);
                }
                if (mydict[i] > target)
                {
                    return i;
                }
            }
            return 0;

        }
    }
}
