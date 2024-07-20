using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class Weekly406
    {

        //You are given an array of integers nums and the head of a linked list.
        //Return the head of the modified linked list after removing all nodes
        //from the linked list that have a value that exists in nums.
        public static LinkedList removeNodes(LinkedList head , int[] array)
        {
            LinkedList current = head;
            LinkedList previous = current;
            while (current != null)
            {
                if(array.Contains(current.value))
                {
                    if(current == head)
                    {
                        head = current.next;                         
                    }
                    else
                    {
                        previous.next = current.next;                        
                    }                    
                }
                else
                {
                    previous = current;
                }
                current = current.next;
            }
            return head;
        }

        private static bool Contains(int value, int[] array)
        {
            foreach (int i in array)
            {
                if(i == value) return true;
            }
            return false;
        }

        //Given a string s containing only digits, return the 
        //lexicographically smallest string that can be obtained after swapping adjacent digits
        //in s with the same parity at most once.
        //Digits have the same parity if both are odd or both are even.
        //For example, 5 and 9, as well as 2 and 4, have the same parity, while 6 and 9 do not.
        public static string getSmallestString(string s)
        {
            int count = 0;
            while(count <= s.Length - 2)
            {
                if (isLexicographic(s[count], s[count+1]))
                {
                    s = swap(s,count ,count+1);
                    break;
                }
                count++;
            }
            return s;
        }

        public static bool isLexicographic(char c1, char c2)
        {
            int i1 = Convert.ToInt32(c1) - Convert.ToInt16('0');
            int i2 = Convert.ToInt32(c2) - Convert.ToInt16('0');
            if(i1 > i2 && ((i1%2==0 && i2%2==0) || (i1%2!=0 && i2%2!=0)))
            {
                return true;
            }
            return false;
        }

        public static string swap(string s, int i, int j) 
        {
            char[] chars = s.ToCharArray();
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
            return new string(chars);
        }

        //Minimum Cost for cutting Cake
        //First Sort the numbers based on Vertical and horizontal cuts in a List 
        //and inside List there would be dictionary with horizontal cuts and number of cuts to be done as value
        //Then loop through list and check if its horizontal cut or vertical
        //if horizontal cut then increase the value for vertical cuts and vice versa until Loop is till the end
        public static int CakeCutting1(int m, int n, int[] horizontalCut, int[] verticalCut)
        {
            List<Cut> combinedList = new List<Cut>();

            foreach(int  i in horizontalCut) 
            {
                combinedList.Add(new Cut() { value = i , type = 'h'});
            }
            foreach (int i in verticalCut)
            {
                combinedList.Add(new Cut() { value = i, type = 'v' });
            }

            combinedList = combinedList.OrderByDescending(x => x.value).ToList();

            int computedCost = 0;
            for(int i = 0; i < combinedList.Count;i++)
            {
                if (combinedList[i].type == 'h')
                    makeVerticalIncrease(i, combinedList);
                else
                    makeHorizontalIncrease(i,combinedList);

                computedCost += combinedList[i].value * combinedList[i].noOfCuts;
            }
            return computedCost;
        }

        public static void makeVerticalIncrease(int position, List<Cut> combinedList)
        {
            for(int i = position + 1; i < combinedList.Count;i++)
            {
                if (combinedList[i].type == 'v')
                    combinedList[i].noOfCuts++;
            }
        }

        public static void makeHorizontalIncrease(int position, List<Cut> combinedList)
        {
            for (int i = position + 1; i < combinedList.Count; i++)
            {
                if (combinedList[i].type == 'h')
                    combinedList[i].noOfCuts++;
            }
        }
    }

    public class Cut
    {
        public int value { get; set; }
        public char type { get; set; }
        public int noOfCuts { get; set; } = 1;
    }
}
