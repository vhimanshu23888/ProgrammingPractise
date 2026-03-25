using ProblemSolving.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    public class Easy_LinkedList_IsPalindrome
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode tempHead = head;
            ListNode ReverseHead = null;
            ListNode prevNode = head;

            int sum = 0;
            if (head == null)
                return false;
            if (head.next == null)
                return true;
            if (head.next.next == null)
            {
                if (head.val != head.next.val)
                    return false;
                else return true;
            }

            tempHead = LinkedListHelper.GetMidNode(tempHead);

            ReverseHead = LinkedListHelper.Reverse(tempHead);

            while (ReverseHead != null)
            {
                if (head.val != ReverseHead.val)
                    return false;
                head = head.next;
                ReverseHead = ReverseHead.next;
            }
            return true;
        }

    }
}
