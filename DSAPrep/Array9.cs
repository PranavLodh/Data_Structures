using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array9
    {
        public static void mergeArray(int[] a, int[] b) 
        {
            int e1 = 0;           
            while(e1 < a.Length) 
            {
                if(a[e1] > b[0])
                {
                    int temp = a[e1];
                    a[e1] = b[0];
                    b[0] = temp;                    
                    b = b.OrderBy(x => x).ToArray();
                }
                e1++;
            }
            for(int i = 0; i < a.Length; i++) 
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("this is second array");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
