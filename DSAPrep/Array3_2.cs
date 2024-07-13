using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given a double x and integer n, calculate x raised to power n.
    //Basically Implement pow(x, n).
    internal class Array3_2
    {
        public static float CalculatePower(float x, int n)
        {
            float result = 1;
            for (int i = 0; i < n/2; i++) 
            {
                result *= x;
            }
            if( n%2  == 0 ) 
            {
                return result * result;
            }
            else
            {
                return result * result * x;
            }
        }
    }
}
