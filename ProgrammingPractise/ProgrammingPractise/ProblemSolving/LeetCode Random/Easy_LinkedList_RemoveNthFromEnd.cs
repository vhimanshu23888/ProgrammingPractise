using ProblemSolving.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    public class Easy_LinkedList_RemoveNthFromEnd
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head == null)
                return null;
            if(head.next == null)
                return null;
            if(head.next.next == null)
            {
                if(n ==1)
                {
                    head.next = null;
                    return head;
                }
                else
                {
                    head = head.next;
                    return head;
                }
            }
            ListNode slow = head;
            ListNode fast = head;
            for(int i =0; i<= n;i++)
            {
                if (fast != null)
                    fast = fast.next;
                else
                {
                    head = head.next;
                    return head;
                }
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }
}
