using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Class1
    {
        //A = [1,3,2]
        //A = [9,4,6,7,7]
        public static int[] solution(int[] A)
        {
            for(int i=0;i<A.Length;i++)
            {
                while(isRepeated(A,i))
                {
                    A[i] -= 1;
                }
            }
            return A;
        }

        public static bool isRepeated(int[] A, int index)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (i!=index && A[i] == A[index])
                    return true;
            }
            return false;
        }


        }
}
