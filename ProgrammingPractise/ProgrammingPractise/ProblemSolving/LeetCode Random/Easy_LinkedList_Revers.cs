using ProblemSolving.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    public class Easy_LinkedList_Revers
    {
        public ListNode Reverse(ListNode head)
        {
            if(head == null)
                return null;
            if(head.next == null)
                return head;

            ListNode prev = null;
            ListNode nextNode = null;

            while (head != null)
            {
                nextNode = head.next;
                head.next = prev;
                prev = head;
                head = head.next;
            }

            return head;
        }
    }
}
