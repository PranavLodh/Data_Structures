using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Array2
    {
        public static int[][] PascalTriangle(int n)
        {
            n++;
            int[][] Triangles = new int[n][];
            int[] firstNode = [1];
            Triangles[0] = firstNode;            
            for(int i = 2; i < n; i++)
            {
                int[] newnode = new int[i];
                for(int j = 0; j < i; j++)
                {
                    if(j == 0 || j == i-1)
                    {
                        newnode[j] = 1;
                    }
                    else
                    {
                        newnode[j] = Triangles[i - 2][j - 1] + Triangles[i - 2][j];
                    }
                }
                Triangles[i-1] = newnode;
            }
            return Triangles;
        }

        public static void PrintTriangle(int[][] triangle)
        {
            Console.WriteLine("Printing Pascal Triangle");
            for(int i = 0; i < triangle.Length-1; i++)
            {
                for(int j = 0;j < triangle[i].Length; j++)
                {
                    Console.Write(triangle[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
