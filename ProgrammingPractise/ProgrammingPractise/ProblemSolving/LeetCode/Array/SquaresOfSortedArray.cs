using System;
using System.Collections.Generic;
using System.Text;

/*
 Squares of a Sorted Array

Solution
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

 

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in non-decreasing order.
 

Follow up: Squaring each element and sorting the new array is very trivial, could you find an O(n) solution using a different approach?
 */
namespace ProblemSolving.LeetCode.Array
{
    class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            int headPointer = 0; int tailPointer = nums.Length - 1;
            int[] result = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (headPointer == tailPointer)
                {
                    result[0] = (int)Math.Pow(nums[tailPointer], 2);
                    break;
                }
                if (Math.Abs(nums[headPointer]) < Math.Abs(nums[tailPointer]))
                {
                    result[i] = (int)Math.Pow(nums[tailPointer], 2);
                    tailPointer--;
                }
                else
                {
                    result[i] = (int)Math.Pow(nums[headPointer], 2);
                    headPointer++;
                }
            }
            return result;
        }
    }
}
/*
 Runtime: 310 ms
Memory Usage: 55.1 MB

 */