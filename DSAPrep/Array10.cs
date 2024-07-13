using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given an array of N + 1 size, where each element is between 1 and N.
    //Assuming there is only one duplicate number, your task is to find the duplicate number.
    internal class Array10
    {
        public static int getDuplicateNumber(int[] array) 
        {            
            int idealSum = ((array.Length - 1)/2) * (2 + array.Length - 2);            
            int sum = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                sum += array[i];
            }
            return sum-idealSum;
        }
    }
}
