/*
 
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:

2-->4-->3
5-->6-->4

================
7-->0-->8

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.


 */


using ProblemSolving.common;
using System.Numerics;

namespace ProblemSolving
{
    class MED_AddTwoNumbersFromLinkedLists
    {
        public ListNode AddTwoNumbers(ListNode headNodeList1, ListNode headNodeList2)
        {
            BigInteger bigIntegerList1 = linkedListToBigInteger(headNodeList1);
            BigInteger bigIntegerList2 = linkedListToBigInteger(headNodeList2);
            BigInteger resultInteger = BigInteger.Add(bigIntegerList1,bigIntegerList2);

            ListNode headOutputListNode = new ListNode();
            ListNode tempNode = new ListNode();
            char[] resultCharsArray = resultInteger.ToString().ToCharArray();
            for(int i = resultCharsArray.Length-1; i >=0;i--)
            {
                if(i == resultCharsArray.Length - 1)
                {
                    tempNode = new ListNode { val = ((int)resultCharsArray[i] - 48), next = null };
                    headOutputListNode = tempNode;
                }
                else
                {
                    tempNode.next = new ListNode { val = ((int)resultCharsArray[i] - 48) };
                    tempNode = tempNode.next;
                }
            }
            return headOutputListNode;
        }

        private BigInteger linkedListToBigInteger(ListNode headNodeList1)
        {
            ListNode tempNode = headNodeList1;
            BigInteger placeValue = 1;
            BigInteger bigIntegerList1 = new BigInteger();

            if (headNodeList1.next == null)
                bigIntegerList1 = headNodeList1.val;
            else
            {
                while (true)
                {
                    bigIntegerList1 = bigIntegerList1 + (placeValue * tempNode.val);
                    placeValue = placeValue * 10;
                    tempNode = tempNode.next;

                    if (tempNode == null)
                        break;
                }
            }
            return bigIntegerList1;
        }
    }
}

/*
 Accepted
Runtime --> 78ms
Beats 91.07%of users with C#
Memory --> 52.02MB
Beats 5.02%of users with C#
 */
