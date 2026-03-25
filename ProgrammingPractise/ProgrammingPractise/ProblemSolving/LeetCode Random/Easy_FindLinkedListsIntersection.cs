using ProblemSolving.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    public class Easy_FindLinkedListsIntersection
    {
        public ListNode GetIntersectionNodeHashSet(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> linkedListA = new HashSet<ListNode>() { headA };
            while (headA.next != null)
            {
                linkedListA.Add(headA.next);
                headA = headA.next;
            }
            if (linkedListA.Contains(headB))
                return headB;
            while (headB.next != null)
            {
                if (linkedListA.Contains(headB.next))
                    return headB;
                else
                    headB = headB.next;
            }
            return null;
        }

        //fastest and most Space optimized
        public ListNode GetIntersectionNodeLengthOfLinkedLists(ListNode ptrListA, ListNode ptrListB)
        {
            //ListNode ptrListA = headA;
            //ListNode ptrListB = headB;
            int lengthListA = LinkedListHelper.GetLength(ptrListA);
            int lengthListB = LinkedListHelper.GetLength(ptrListB);

            int iterationCount = lengthListB - lengthListA;
            if (iterationCount > 0)
            {
                for (int i = 0; i <= iterationCount; i++)
                {
                    ptrListB = ptrListB.next;
                }
            }
            else
            {
                iterationCount = iterationCount * -1;
                for (int i = 0; i <= iterationCount; i++)
                {
                    ptrListA = ptrListA.next;
                }
            }

            while (ptrListA != null && ptrListB != null)
            {
                if (ptrListA != ptrListB)
                {
                    ptrListA = ptrListA.next;
                    ptrListB = ptrListB.next;
                }
                else
                    return ptrListA;
            }
            return null;

        }

        public ListNode GetIntersectionNodeTwoPointers(ListNode headA, ListNode headB)
        {
            ListNode ptrListA = headA;
            ListNode ptrListB = headB;

            if(ptrListA == null  || ptrListB == null)
                return null;

            while (ptrListA != ptrListB)
            {
                ptrListA = (ptrListA != null) ? ptrListA.next : headB;
                ptrListB = (ptrListB != null) ? ptrListB.next : headA;
            }
            return ptrListA;
        }
    }
}
