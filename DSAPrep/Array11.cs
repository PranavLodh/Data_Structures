using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAPrep
{
    internal class Array11
    {
        public static void getDuplicateAndMissingNumber(int[] array)
        {
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
            int Duplicate = 0;
            foreach (var item in array) 
            {
                if(keyValuePairs.ContainsKey(item))
                {
                    Duplicate = item;
                    break;
                }
                keyValuePairs.Add(item, 1);
            }
            int idealSum = 0;
            for(int i=1; i <= array.Length; i++) 
            {
                idealSum += i;
            }
            int MissingNumber = idealSum - (array.Sum() - Duplicate);
            Console.WriteLine("MissingNumber is " + MissingNumber + " and Duplicate Number is " + Duplicate);
        }
    }
}
