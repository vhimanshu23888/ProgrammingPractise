using System;
using System.Collections.Generic;
using System.Text;

//Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

//You must implement a solution with a linear runtime complexity and use only constant extra space.

//Example 1:

//Input: nums = [2, 2, 1]

//Output: 1

//Example 2:

//Input: nums = [4, 1, 2, 1, 2]

//Output: 4

//Example 3:

//Input: nums = [1]

//Output: 1

//Constraints:

//1 <= nums.length <= 3 * 104
//- 3 * 104 <= nums[i] <= 3 * 104
//Each element in the array appears twice except for one element which appears only once.


namespace ProblemSolving.LeetCode_Random
{
    internal class Easy_SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            if (nums.Length == 2 && nums[0] == nums[1])
                return nums[0];

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (result.Contains(nums[i]))
                    result.Remove(nums[i]);
                else
                    result.Add(nums[i]);
            }
            return result[0];
        }
        public int SingleNumberFasterSolution(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res ^= nums[i];
            }
            return res;
        }
    }
}
