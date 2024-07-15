using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array4_1
    {
        //Problem Statement: Given an array of integers arr[] and an integer target.
        //1st variant: Return YES if there exist two numbers such that their sum is equal to the target.
        //Otherwise, return NO.
        //2nd variant: Return indices of the two numbers such that their sum is equal to the target.
        //Otherwise, we will return { -1, -1}.
        public static void Sum2Array(int[] array,int target)
        {
            for(int i = 0; i < array.Length - 1 ; i++) 
            {
                if (array[i] > target)
                    continue;
                for(int j = i+1; j < array.Length;j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        Console.WriteLine($"The first number is {array[i]} and the second number is {array[j]}");
                        return;
                    }
                }
            }
            Console.WriteLine("No Combination found");
        }

        //Method 2 Using dictionary
        public static void Sum2Array2(int[] array, int target)
        {
            Dictionary<int,int> mydict = new Dictionary<int,int>();
            for (int i = 0; i < array.Length - 1; i++)
            {
                int remainder = target - array[i];
                if(mydict.ContainsKey(remainder))
                {
                    Console.WriteLine($"The two numbers are {array[i]} and {remainder}");
                    return;
                }
                else
                {
                    mydict.Add(array[i], i);
                }
            }
            Console.WriteLine("No Combination found");
        }
    }
}
