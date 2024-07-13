using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array4
    {
        public static int getHighestSum(int[] array)
        {
            int max = 0;            
            List<int> maxArray = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                List<int> currentArray = new List<int>();
                int sum = 0;                
                for(int j = i; j<array.Length;j++)
                {                    
                    sum += array[j];
                    currentArray.Add(array[j]);
                    if(sum > max)
                    {
                        max = sum;
                        maxArray = currentArray.ToList();
                    }
                }
            }
            Console.WriteLine("Max Array is");
            for(int i = 0;i<maxArray.Count;i++)
            {
                Console.Write(maxArray[i] + "\t");
            }
            return max;
        }
    }
}
