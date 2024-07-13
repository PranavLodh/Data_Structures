using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given an array of N integers.
    //Find the elements that appear more than N/3 times in the array. If no such element exists, return an empty vector.
    internal class Array3_4
    {
        public static List<int> getFrequentNumbers(int[] array)
        {
            int target = array.Length / 3;
            Dictionary<int,int> mydict = new Dictionary<int,int>();
            List<int> mylist = new List<int>();
            foreach (int i in array) 
            {
                if(mydict.ContainsKey(i))
                {
                    mydict[i]++;
                    if (mydict[i] > target) 
                    {
                        if(!mylist.Contains(i))
                        {
                            mylist.Add(i);
                        }
                    }
                }
                else
                {
                    mydict.Add(i, 1);
                }
            }
            return mylist;
        }
    }
}
