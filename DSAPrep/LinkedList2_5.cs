using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given the head of a linked list that may contain a cycle,
    //return the starting point of that cycle.
    //If there is no cycle in the linked list return null.
    internal class LinkedList2_5
    {
        public static LinkedList getStartPoint(LinkedList head)
        {
            List<int> addressList = new List<int>();
            while(head != null) 
            {
                if (addressList.Contains(head.GetHashCode()))
                    return head;
                else
                    addressList.Add(head.GetHashCode());
                
                head = head.next;
            }

            return null;
        }
    }
}
