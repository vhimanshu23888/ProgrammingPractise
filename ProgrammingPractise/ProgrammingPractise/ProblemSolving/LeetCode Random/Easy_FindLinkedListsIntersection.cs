using ProblemSolving.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    public class Easy_FindLinkedListsIntersection
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            List<int> linkedListA = new List<int>() { headA.val };
            while (headA.next != null)
            {
                linkedListA.Add(headA.next.val);
                headA = headA.next;
            }
            if (linkedListA.Contains(headB.val))
                return headB;
            while (headB.next != null)
            {
                if (linkedListA.Contains(headB.next.val))
                    return headB;
            }
            return null;
        }
    }
}
