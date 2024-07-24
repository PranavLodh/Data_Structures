using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Check if the given Linked List is Palindrome
    internal class LinkedList2_4
    {
        public static bool isPalindrome(LinkedList head)
        {
            LinkedList current = head;
            Stack<int> myStack = new Stack<int>();

            while (current != null) 
            {
                myStack.Push(current.value);
                current = current.next;
            }
            current = head;

            while(current != null) 
            {
                if(current.value != myStack.Pop())
                {
                    return false;
                }
                current = current.next;
            }

            return true;
        }
    }
}
