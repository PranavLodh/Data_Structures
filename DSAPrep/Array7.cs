using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array7
    {
        public static int[,] RotateMatrix(int[,] matrix1)
        {
            int rowLength = matrix1.GetLength(0);
            int colLength = matrix1.GetLength(1);
            int[,] matrix2 = new int[colLength, rowLength];
            for(int i = 0; i < matrix2.GetLength(0); i++)
            {
                for(int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i,j] = matrix1[rowLength - j - 1,i];
                }
            }
            return matrix2;
        }

        public static void PrintMatrix(int[,] matrix) 
        {
            for(int i = 0;i < matrix.GetLength(0);i++)
            {
                for(int j = 0;j < matrix.GetLength(1);j++)
                {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
