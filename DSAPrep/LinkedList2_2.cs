using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class LinkedList2_2
    {
        //Detect a Cycle in a Linked List
        public static bool isCyclic(LinkedList head)
        {
            LinkedList fast = head;
            LinkedList slow = head;
            while (fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                    return true;                
            }
            return false;
        }
    }
}
