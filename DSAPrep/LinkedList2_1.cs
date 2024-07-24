using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Given the heads of two singly linked-lists headA and headB,
    //return the node at which the two lists intersect.
    //If the two linked lists have no intersection at all, return null.
    internal class LinkedList2_1
    {
        public static LinkedList getCommonNode(LinkedList head1, LinkedList head2) 
        {            
            while(head1!=null)
            {
                LinkedList current2 = head2;
                while (current2 != null) 
                {
                    if (head1 == current2)
                        return head1;

                    current2 = current2.next;
                }
                head1 = head1.next;
            }
            return null;
        }

        public static LinkedList getCommonNode2(LinkedList head1, LinkedList head2)
        {
            List<int> hashCodes = new List<int>();
            //Using Hashing
            while (head1!=null) 
            {
                hashCodes.Add(head1.GetHashCode());
                head1 = head1.next;
            }
            while (head2!=null) 
            {
                if(hashCodes.Contains(head2.GetHashCode()))
                    return head2;
                head2 = head2.next;
            }
            return null;
        }
    }
}
