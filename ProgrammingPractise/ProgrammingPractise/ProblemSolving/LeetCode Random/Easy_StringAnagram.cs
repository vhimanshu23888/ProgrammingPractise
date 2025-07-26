using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    internal class Easy_StringAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int sSum = 0, tSum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sSum += (int)s[i];
                tSum += (int)t[i];
            }
            return sSum == tSum;
        }
    }
}
