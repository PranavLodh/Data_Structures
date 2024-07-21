using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DSAPrep
{
    internal class LinkedList1_4
    {
        //Problem Statement: Given a linked list and an integer N, the task is to delete the Nth node
        //from the end of the linked list and print the updated linked list.
        public static LinkedList removeNode(LinkedList head,int N)
        {
            if (N != 0)
            {
                LinkedList head1 = head;
                LinkedList current = head;
                for (int i = 0; i <= N; i++)
                {
                    LinkedList node = new LinkedList(0, null);
                    node.next = head1;
                    head1 = node;
                }
                while (current != null)
                {
                    current = current.next;
                    head1 = head1.next;
                }
                if(head1.value != 0)
                    head1.next = head1.next.next;
            }
            return head;
            

        }
    }
}
