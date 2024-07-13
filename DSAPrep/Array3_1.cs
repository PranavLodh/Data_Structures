using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: You have been given a 2-D array 'mat' of size 'N x M' where 'N' and 'M' denote the number of rows and columns, respectively. The elements of each row are sorted in non-decreasing order.
    //Moreover, the first element of a row is greater than the last element of the previous row (if it exists).
    //You are given an integer ‘target’, and your task is to find if it exists in the given 'mat' or not.
    internal class Array3_1
    {
        public static bool isPresent(int[,] mat, int target)
        {
            int rowlength = mat.GetLength(0);
            int collength = mat.GetLength(1);
            for(int i = 0; i < rowlength; i++)
            {
                if (target >= mat[i,0] && target <= mat[i,collength-1])
                {
                    for(int j = 0; j < collength; j++)
                    {
                        if (mat[i,j] == target)
                            return true;
                    }
                }
            }
            return false;
        }

        public static bool isPresent2(int[,] mat, int target)
        {
            int n = mat.GetLength(0);
            int m = mat.GetLength(1);
            //apply binary search:
            int low = 0, high = n * m - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int row = mid / m, col = mid % m;
                if (mat[row,col] == target) return true;
                else if (mat[row,col] < target) low = mid + 1;
                else high = mid - 1;
            }
            return false;
        }
    }
}
