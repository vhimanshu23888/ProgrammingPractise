using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode.Array
{
    public class MissingRanges
    {
        public IList<IList<int>> FindMissingRanges(int[] nums, int lower, int upper)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (upper == lower)
            {
                if(nums.Length == 0 || nums[0] != lower)
                {
                    result.Add(new List<int> { lower, upper });
                }
                return result;
            }

            if(nums.Length == 0)
            {
                result.Add(new List<int> { lower+1, upper-1 });
                return result;
            }
            
            if(nums.Length == 1)
            {

            }


            if (nums[0] - lower > 1)
            {
                result.Add(new List<int> { lower + 1, nums[0] - 1 });
            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] > 1)
                {
                    result.Add(new List<int> { nums[i - 1] + 1, nums[i] - 1 });
                }
            }
            if (upper - nums[nums.Length - 1] > 1)
            {
                result.Add(new List<int> { nums[nums.Length - 1] + 1, upper });
            }
            return result;
        }

    }
}
