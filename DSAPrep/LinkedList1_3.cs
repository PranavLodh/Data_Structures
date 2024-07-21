using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class LinkedList1_3
    {
        //Problem Statement: Given two sorted linked lists, merge them to produce a combined sorted linked list.
        //Return the head of the final linked list created.
        public static LinkedList mergeSortedList(LinkedList head1, LinkedList head2)
        {
            LinkedList head = null;
            LinkedList current = null;
            LinkedList current1 = head1;
            LinkedList current2 = head2;
            LinkedList temp;
            while(current1 != null && current2 != null) 
            {
                if(current1.value <= current2.value) 
                {
                    temp = current1;                    
                    current1 = current1.next;
                }
                else 
                {
                    temp = current2;                    
                    current2 = current2.next;
                }
                if (head == null)
                {
                    head = current = temp;
                }
                else
                {
                    current.next = temp;
                    current = current.next;
                }
            }
            return head;
        }
    }
}
