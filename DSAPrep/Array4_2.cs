using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array4_2
    {
        //Problem Statement: Given an array of N integers, your task is to find unique quads that add up to give a target value.
        //In short, you need to return an array of all the unique quadruplets [arr[a], arr[b], arr[c], arr[d]] such that their sum is equal to a given target.
        public static void GetQuadNumbers(int[] array, int target)
        {
            for(int i = 0; i < array.Length; i++) 
            {               
                for(int j = i+1;j <  array.Length;j++)
                {                                    
                        for (int k = j+1; k < array.Length; k++)
                        {
                                for (int l = k+1; l < array.Length; l++)
                                {                                    
                                        if(array[i] + array[j] + array[k] + array[l] == target)
                                        {
                                            Console.WriteLine($"The first number : {array[i]} , Second Number : {array[j]} , Third Number : {array[k]} , Fourth Number : {array[l]}");
                                        }                                    
                                }
                            
                        }
                    
                }
            }
        }
    }
}
