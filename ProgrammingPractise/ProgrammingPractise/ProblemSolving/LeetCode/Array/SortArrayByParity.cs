using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode.Array
{
    class SortArrayByParity
    {
        public int[] SortArrayByParityMethod(int[] nums)
        {
            if (nums.Length > 1)
            {
                int rearPointer = nums.Length - 1;
                for (int frontPointer = 0; frontPointer < rearPointer; frontPointer++)
                {
                    if (nums[frontPointer] % 2 != 0)
                    {
                        for (int j = rearPointer; j > frontPointer; j--)
                        {
                            if (nums[j] % 2 == 0)
                            {
                                int temp = nums[frontPointer];
                                nums[frontPointer] = nums[j];
                                nums[j] = temp;
                                rearPointer = j - 1;
                                break;
                            }
                        }
                    }
                }
            }
            return nums;
        }
    }
}
