using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class StringWeekly
    {
        public static string GetEncryptedString(string s, int k)
        {

            char[] c1 = s.ToCharArray();
            char[] c2 = (char[])c1.Clone();
            for (int i = 0; i < c1.Length; i++)
            {
                int j = 0;
                if ((i + k) > c1.Length - 1)
                {
                    j = (i + k) - c1.Length;
                }
                else
                {
                    j = (i + k);
                }
                Console.WriteLine(j);
                c2[i] = c1[j];
            }
            return new string(c2);
        }
    }
}
