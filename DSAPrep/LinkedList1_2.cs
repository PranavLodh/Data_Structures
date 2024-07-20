using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given the head of a linked list of integers, determine the middle node of the linked list.
    //However, if the linked list has an even number of nodes, return the second middle node
    internal class LinkedList1_2
    {
        public static int getMiddleElement(LinkedList head)
        {
            LinkedList slow = head;
            LinkedList fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow.value;
        }
    }
}
