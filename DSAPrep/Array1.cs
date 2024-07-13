using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array1
    {

        
        //Set Matrix Zero
        //Problem Statement: Given a matrix if an element in the matrix is 0 then you will have
        //to set its entire column and row to 0 and then return the matrix.

        public static int[,] SetMatrixZero(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for(int j=0;j < cols; j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        matrix = SetColumnMinusone(matrix, j);
                        matrix = SetRowMinusone(matrix, i);
                    }
                }
            }
            
            return MakeAllZeros(matrix);
        }

        static int[,] SetColumnMinusone(int[,] matrix, int column)
        {
            int rows = matrix.GetLength(0);
            for (int i = 0;i < rows; i++)
            {
                matrix[i,column] = -1;
            }
            return matrix;
        }

        static int[,] SetRowMinusone(int[,] matrix, int row)
        {
            int columns = matrix.GetLength(0);
            for (int i = 0; i < columns; i++)
            {
                matrix[row,i] = -1;
            }
            return matrix;
        }

        static int[,] MakeAllZeros(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == -1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Better Approach
        public static int[,] SetMatrixZero1(int[,] matrix)
        {
            
            int rowlength = matrix.GetLength(0);
            int collength = matrix.GetLength(1);
            int[] rows = new int[rowlength];
            int[] cols = new int[collength];
            for (int i = 0; i < rowlength; i++)
            {
                for (int j = 0; j < collength; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rows[i] = 1;
                        cols[j] = 1;
                    }
                }
            }
            return MakeAllZeros1(matrix,rows,cols);
        }

        static int[,] MakeAllZeros1(int[,] matrix, int[] rows, int[] cols)
        {
            int rowlength = matrix.GetLength(0);
            int columnlength = matrix.GetLength(1);
            for (int i = 0; i < rowlength; i++)
            {
                for (int j = 0; j < columnlength; j++)
                {
                    if (rows[i]==1 || cols[j]==1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
