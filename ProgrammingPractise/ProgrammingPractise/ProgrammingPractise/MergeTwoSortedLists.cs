﻿/*
 You are given the heads of two sorted linked lists list1 and list2.
Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
Return the head of the merged linked list.

Example 1:

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]


Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order.
 */

namespace ProgrammingPractise
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int value = 0, ListNode listNode = null)
        {
            val = value;
            next = listNode;
        }
    }
    internal class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode _resultHead = new ListNode();
            ListNode _tempNode = _resultHead;


            while (true)
            {
                if (list1 == null)
                {
                    _tempNode.next = list2;
                    break;
                }

                if (list2 == null)
                {
                    _tempNode.next = list1;
                    break;
                }

                if (list1.val < list2.val)
                {
                    _tempNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    _tempNode.next = list2;
                    list2 = list2.next;
                }
            }
            return _resultHead.next;
        }
    }
}
