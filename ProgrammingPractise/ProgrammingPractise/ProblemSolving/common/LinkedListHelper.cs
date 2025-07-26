using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProblemSolving.common
{
    public class LinkedListHelper
    {
        public ListNode ArraytoLinkedList(int[] input)
        {
            if (input.Length == 0) return null;

            ListNode head = new ListNode() { val = input[0] };
            ListNode listNode = head;

            for (int i = 1; i < input.Length; i++)
            {
                listNode.next = new ListNode() { val = input[i], next = null };
            }
            return head;
        }
        public ListNode ArraytoCyclicLinkedList(int[] input,int pos)
        {
            if (input.Length == 0) return null;
            
            ListNode head = new ListNode() { val = input[0] };
            ListNode listNode = head;
            List<ListNode> list = new List<ListNode>() {head };
            for (int i = 1; i < input.Length; i++)
            {
                ListNode temp = new ListNode() { val = input[i], next = null };
                
                if (i == input.Length - 1)
                {
                    temp.next = list[pos];
                }
                listNode.next = temp;
                list.Add(temp);
                listNode = listNode.next;

            }

            return head;
        }
    }
}
