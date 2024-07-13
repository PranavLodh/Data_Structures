using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array3_5
    {
        //Problem Statement: Given a matrix m X n, count paths from left-top to the right bottom of a
        //matrix with the constraints that from each cell you can either only move to the rightward
        //direction or the downward direction.
        public static void countPaths(int m, int n)
        {            
            int count = Count(0, 0, m, n);
            Console.WriteLine(count);
        }

        public static int Count(int i, int j, int m, int n)
        {
            if (i >= m || j >= n)
                return 0;
            else if (i == m-1 && j == n-1)
                return 1;
            else return Count(i + 1, j, m, n) + Count(i, j + 1, m, n);
        }
    }
}
