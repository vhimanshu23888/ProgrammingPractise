using System;
using System.Collections.Generic;
using System.Text;
using ProblemSolving.common;
namespace ProblemSolving.LeetCode_Random
{
    public class Easy_CyclicLinkedList
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            if (head.next == null) return false;
            if (head.next.next ==null) return false;

            ListNode slowPointer = head;
            ListNode fastPointer = head.next.next;

            while (fastPointer.next != null && fastPointer.next.next != null)
            {
                if (slowPointer.val == fastPointer.val)
                    return true;
                else
                {
                    slowPointer = slowPointer.next;
                    fastPointer = fastPointer.next.next;
                }
            }
            return false;
        }
    }
}
