using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAPrep
{
    internal class Array12
    {

        //Problem Statement: Given an array of N integers, count the inversion of the array (using merge-sort).

        //What is an inversion of an array? Definition: for all i & j<size of array,
        //if i<j then you have to find pair (A[i], A[j]) such that A[j] < A[i].
        public static void countInversionArray(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                for(int j=i; j < array.Length; j++)
                {
                    if(i != j)
                    {
                        if (array[j] < array[i])
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine($"The count of Inversion is {count}");
        }
    }
}
