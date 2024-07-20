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
        public static List<List<int>> getNextPermutation(int[] array,int index,List<List<int>> ds)
        {
            if(index == array.Length-1)
            {
                List<int> numbers = new List<int>();
                for(int i = 0; i < array.Length; i++)
                {
                    numbers.Add(array[i]);
                }
                ds.Add(numbers);                
            }
            for(int i=index; i < array.Length; i++) 
            {
                swap(array,i,index);
                getNextPermutation(array, index + 1, ds);
                swap(array,i,index);
            }
            return ds;
        }
        public static void printArray(List<List<int>> ds)
        {
            for(int i=0; i<ds.Count ; i++)
            {
                for(int j=0; j < ds[i].Count ; j++)
                {
                    Console.Write(ds[i][j].ToString());
                }
                Console.WriteLine();
            }
        }        

        public static int[] swap(int[] array, int i, int j) 
        {            
            int temp= array[i];
            array[i] = array[j];
            array[j] = temp;
            return array;
        }

    }
}
