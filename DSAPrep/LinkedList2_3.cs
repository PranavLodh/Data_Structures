using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSAPrep
{
    //Problem Statement: Given the head of a singly linked list of `n` nodes and an integer `k`,
    //where k is less than or equal to `n`. Your task is to reverse the order of each group of `k`
    //consecutive nodes, if `n` is not divisible by `k`, then the last group of remaining nodes should remain unchanged.
    internal class LinkedList2_3
    {
        //Create a function reverse linkedlist which will reverse the linkedlist for you 
        //and create a loop where i = i+k

        public static (LinkedList,LinkedList) reverseLinkedList(LinkedList head,int k)
        {            
            LinkedList newhead = head;
            LinkedList tail = newhead;
            LinkedList endNode = head;
            LinkedList previous = null;            
            while(k!=0)
            { 
                newhead = head;
                newhead.next = previous;
                previous = newhead;
                k--;
            }
            return (newhead,tail);
        }

        public static void reverseInSize(LinkedList head,int k) 
        {
            LinkedList current = head;

            while (current!= null) 
            {
                //(LinkedList newhead,LinkedList tail) = reverseInSize(current,k);
            }            
        }
    }
}
