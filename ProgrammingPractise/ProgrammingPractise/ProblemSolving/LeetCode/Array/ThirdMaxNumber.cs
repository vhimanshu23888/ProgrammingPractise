using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode.Array
{
    class ThirdMaxNumber
    {
        public int findThirdMaxNumber(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            if(nums.Length ==2)
            {
                if (nums[0] > nums[1])
                    return nums[0];
                else
                    return nums[1];
            }

            int max = nums[0],secondMax,thirdMax;
            secondMax = thirdMax = (int)Math.Pow(-2, 31);
            bool isFirstMaxProcessed = false, isSecondMaxProcessed = false, isThirdMaxProcessed = false;
            for(int i = 0;i<nums.Length;i++)
            {
                if ((!isSecondMaxProcessed && nums[i] != secondMax) ||(!isFirstMaxProcessed && nums[i] != max))
                {
                    if (nums[i] > max)
                    {
                        if (secondMax != (int)Math.Pow(-2, 31))
                            isThirdMaxProcessed = true;
                        thirdMax = secondMax;
                        secondMax = max;
                        max = nums[i];
                    }
                    else if (nums[i] > secondMax && nums[i] < max)
                    {
                        if (secondMax != (int)Math.Pow(-2, 31))
                            isThirdMaxProcessed = true;
                        thirdMax = secondMax;
                        secondMax = nums[i];
                    }
                    else if (nums[i] >= thirdMax)
                    {
                        isThirdMaxProcessed = true;
                        thirdMax = nums[i];
                    }
                }
                //else if (nums[i] == thirdMax && isThirdMaxProcessed == false)
               // {
                //    isThirdMaxProcessed = true;
               // }
            }
            if (isThirdMaxProcessed)
                return thirdMax;
            else
                return max;
        }
    }
}
