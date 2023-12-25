using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.common
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
}
