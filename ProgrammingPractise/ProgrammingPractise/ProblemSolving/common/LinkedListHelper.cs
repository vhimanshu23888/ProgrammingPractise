using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace ProblemSolving.common
{
    public class LinkedListHelper
    {
        public static ListNode ArraytoLinkedList(int[] input)
        {
            if (input.Length == 0) return null;

            ListNode head = new ListNode() { val = input[0] };
            ListNode listNode = head;

            for (int i = 1; i < input.Length; i++)
            {
                ListNode temp  = new ListNode() { val = input[i], next = null };
                listNode.next = temp;
                listNode = listNode.next;
            }
            return head;
        }
        public static ListNode ArraytoCyclicLinkedList(int[] input,int pos)
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
        public static int GetLength(ListNode head)
        {
            ListNode tempNode = head;
            int length = 0;
            while (tempNode != null)
            {
                length++;
                tempNode = tempNode.next;
            }
            return length;
        }
        public static ListNode Reverse(ListNode head)
        {
            if (head == null)
                return null;
            if (head.next == null)
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

            return prev;
        }
        public static ListNode Reverse(ListNode head,ListNode previousNode)
        {
            ListNode currentNode = head;
            if (currentNode == null)
                return null;
            if (currentNode.next == null)
                return currentNode;

            ListNode prev = previousNode;
            ListNode nextNode = null;

            while (currentNode != null)
            {
                nextNode = currentNode.next;
                currentNode.next = prev;
                prev = currentNode;
                if (nextNode != null)
                {
                    currentNode = nextNode;
                }
                else
                    break;
            }

            return currentNode;
        }
        public static ListNode GetMidNode (ListNode head)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            return slowPointer;
        }

        public static void printList(ListNode head)
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }
        }
    }
}
