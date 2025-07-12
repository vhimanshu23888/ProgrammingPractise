using System;
using System.Collections.Generic;
using System.Text;
/*
 Given an array nums of size n, return the majority element.
The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109


Follow-up: Could you solve the problem in linear time and in O(1) space?
 */
namespace ProblemSolving.LeetCode_Top150
{
    public class MajorityElement
    {
        //Approach 1
        public int GetMajorityElement(int[] nums)
        {
            if(nums.Length<=2)
            {
                return nums[0];
            }
            Dictionary<int, int> countDictionary = new Dictionary<int, int>();
            int counter = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    if(i==nums.Length-2) //last element
                    {
                        counter = counter + 1;
                        if (countDictionary.ContainsKey(nums[i]))
                        {int value=0;
                            countDictionary[nums[i]] = (countDictionary.TryGetValue(nums[i], out value) ? value : 0) + counter;
                        }
                        else
                            countDictionary.Add(nums[i], counter);
                    }
                    counter++;
                }
                else
                {
                    if (countDictionary.ContainsKey(nums[i]))
                    {
                        countDictionary[nums[i]] = countDictionary.TryGetValue(nums[i], out int value) ? value : 0 + counter;
                    }
                    else
                    {
                        countDictionary.Add(nums[i], counter);
                    }

                    if (i == nums.Length - 2) //last element
                    {
                        if (countDictionary.ContainsKey(nums[i + 1]))
                        {
                            countDictionary[nums[i + 1]] = countDictionary.TryGetValue(nums[i + 1], out int value) ? value : 0 + 1;
                        }
                        else
                            countDictionary.Add(nums[i + 1], 1);
                    }
                    counter = 1;
                }
            }
            foreach (var output in countDictionary)
            {
                if (output.Value > nums.Length / 2)
                    return output.Key;
            }
            return -1;
        }
    }
}
