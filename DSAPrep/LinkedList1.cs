using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class LinkedList1
    {

        //Problem Statement: Problem Statement: Given the head of a singly linked list,
        //write a program to reverse the linked list, and return the head pointer to the reversed list.
        public static LinkedList reverseLinkedList(LinkedList head)
        {
            LinkedList rhead = null; 
            LinkedList current;
            while (head != null) 
            {
                current = new LinkedList();
                current.value = head.value;
                current.next = rhead;
                rhead = current;                
                head = head.next;
            }
            return rhead;
        }
    }

    public class LinkedList
    {
        public int value;
        public LinkedList next;
        public LinkedList(int value,LinkedList next)
        {
            this.value = value;
            this.next = next;
        }

        public LinkedList() { }
        
    }
}
