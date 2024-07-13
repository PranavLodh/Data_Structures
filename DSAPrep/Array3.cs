using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given an array Arr[] of integers, rearrange the numbers of the given array into
    //the lexicographically next greater permutation of numbers.

    //If such an arrangement is not possible, it must rearrange to the lowest
    //possible order(i.e., sorted in ascending order).
    internal class Array3
    {
        public static int[] getNextPermutation(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == array.Length) 
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] += 1;
                }
            }
            return array;
        }
        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }            
        }
        public static void recursegetPermutations(int index,int[] array,List<List<int>> ans)
        {            
            if(index == array.Length)
            {
                List<int> ds = new List<int>();
                for(int i = 0;i < array.Length;i++) 
                {
                    ds.Add(array[i]);
                }
                ans.Add(ds);
            }
            for (int i = 0; i < array.Length; i++)
            {
                swap(array, i,index);
                recursegetPermutations(index+1, array, ans);
                swap(array, i, index);
            }
            
            for(int i = 0; i< ans.Count(); i++)
            {
                for(int j = 0; j < ans[i].Count(); j++) 
                {
                    Console.WriteLine(ans[i][j] + "\t");
                }
            }
        }

        public static int[] swap(int[] array, int i, int j) 
        {
            int temp;
            temp= array[i];
            array[i] = array[j];
            array[j] = temp;
            return array;
        }

    }
}
