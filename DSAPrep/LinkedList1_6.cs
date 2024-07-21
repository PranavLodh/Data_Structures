using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    //Problem Statement: Write a function to delete a node in a singly-linked list.
    //You will not be given access to the head of the list instead, you will be given access to the node to be deleted directly.
    //It is guaranteed that the node to be deleted is not a tail node in the list.
    internal class LinkedList1_6
    {
        public static void deleteNode(LinkedList node,LinkedList head)
        {
            node.value = node.next.value;
            node.next = node.next.next;
        }
    }
}
