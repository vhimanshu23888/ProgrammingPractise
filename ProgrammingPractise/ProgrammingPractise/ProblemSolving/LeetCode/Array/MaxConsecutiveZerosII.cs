using System;
using System.Collections.Generic;
using System.Text;
/*
 Given a binary array nums, return the maximum number of consecutive 1's in the array if you can flip at most one 0.

 

Example 1:

Input: nums = [1,0,1,1,0]
Output: 4
Explanation: 
- If we flip the first zero, nums becomes [1,1,1,1,0] and we have 4 consecutive ones.
- If we flip the second zero, nums becomes [1,0,1,1,1] and we have 3 consecutive ones.
The max number of consecutive ones is 4.
Example 2:

Input: nums = [1,0,1,1,0,1]
Output: 4
Explanation: 
- If we flip the first zero, nums becomes [1,1,1,1,0,1] and we have 4 consecutive ones.
- If we flip the second zero, nums becomes [1,0,1,1,1,1] and we have 4 consecutive ones.
The max number of consecutive ones is 4.
 

Constraints:

1 <= nums.length <= 105
nums[i] is either 0 or 1.
 

Follow up: What if the input numbers come in one by one as an infinite stream? In other words, you can't store all numbers coming from the stream as it's too large to hold in memory. Could you solve it efficiently?
 
 */
namespace ProblemSolving.LeetCode.Array
{
    class MaxConsecutiveOnesII
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            if (nums.Length == 1)
                return 1;

            int left = 0;
            int currentZero = -1;
            int max = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    if (currentZero == -1)
                    {
                        currentZero = right;
                    }
                    else
                    {
                        if (right - left > max)
                        {
                            max = right - left;
                        }
                        left = currentZero + 1;
                        currentZero = right;
                    }
                }
                if (right == nums.Length - 1 && nums[right] == 1)
                {
                    if ((right + 1) - left > max)
                        max = (right + 1) - left;
                }
            }
            if (left == 0)
                max = nums.Length;

            return max;
        }
    }
}