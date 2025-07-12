using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving.LeetCode.Array
{
    class DissappearedNumbers
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> result = new List<int>();
            result.AddRange(Enumerable.Repeat(0,nums.Length+1));

            for (int i = 0; i < nums.Length; i++)
            {
                result[nums[i]]= nums[i];
                //temp[nums[i]-1] = nums[i];
            }
            int counter = 0;
            for (int i = 1; i <= nums.Length; i++)
            {
                if (result[i] == 0)
                {
                    result.Add(i);
                    counter++;
                }
            }
            return result.GetRange(nums.Length + 1, counter);
        }
    }
}
