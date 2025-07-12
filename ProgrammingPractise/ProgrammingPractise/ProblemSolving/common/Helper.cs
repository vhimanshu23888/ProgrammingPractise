using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.common
{
    public class Helper
    {
        public static bool IsStringPallindrome(string s)
        {
            for(int i =0;i<s.Length/2;i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }
        public int[] reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
            return nums;
        }
    }
}
