using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given an array consisting of only 0s, 1s, and 2s.
    //Write a program to in-place sort the array without using inbuilt sort functions.
    //( Expected: Single pass-O(N) and constant space)


    internal class Array5
    {
        
        public static int[] SortArray(int[] a)
        {
            int mid = 0;
            int high = a.Length - 1;
            int low = 0;
            while (mid <= high)
            {
                if (a[mid]==0)
                {
                    int temp = a[mid];
                    a[mid] = a[low];
                    a[low] = temp;                    
                    low++;
                    mid++;
                }
                else if (a[mid]==2) 
                {
                    int temp = a[mid];
                    a[mid] = a[high];
                    a[high] = temp;                    
                    high--;
                }
                else
                {
                    mid++;
                }
            }
            return a;
        }
    }
}
