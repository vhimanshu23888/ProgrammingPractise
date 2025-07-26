using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    internal class Easy_SummaryRanges
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            if (nums.Length == 1)
            {
                result.Add(nums[0].ToString());
                return result;
            }

            int k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i]!= nums[i - 1] +1)
                {
                    if (k == i - 1)
                    {
                        result.Add(nums[i - 1].ToString());
                    }
                    else
                    {
                        result.Add($"{nums[k]}->{nums[i - 1]}");
                    }
                    k = i;
                }
                if (i == nums.Length - 1)
                {
                    if (k == i)
                    {
                        result.Add(nums[i].ToString());
                    }
                    else
                    {
                        result.Add($"{nums[k]}->{nums[i]}");
                    }
                }
            }
            return result;
        }
    }
}
