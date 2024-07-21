using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrep
{
    internal class LinkedList1_5
    {
        //Problem Statement: Given the heads of two non-empty linked lists representing two non-negative integers.
        //The digits are stored in reverse order, and each of their nodes contains a single digit.
        //Add the two numbers and return the sum as a linked list.
        public static long addTwoNumbers(LinkedList head1, LinkedList head2) 
        {
            int borrow = 0;
            long sum = 0;
            while(head1 != null || head2 != null)
            {
                int temp_sum = (head1!=null?head1.value:0) + (head2!=null? head2.value:0) + borrow;
                if (temp_sum >= 10) 
                {
                    borrow = 1;
                    temp_sum = temp_sum % 10;
                }
                else
                {
                    borrow = 0;
                }
                sum = sum * 10 + temp_sum;
                head1 = head1!=null?head1.next:null;
                head2 = head2!=null?head2.next:null;                
            }
            if (borrow != 0) 
            {
                sum = sum * 10 + borrow;
            }
            return sum;
        }
    }
}
