using ProblemSolving.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode.Microsoft
{
    class ValidPallindrome
    {
        //65-90,97-122
        public bool IsPalindrome(string s)
        {
            if (s.Trim() == "")
                return true;
            StringBuilder resultString = new StringBuilder();
            for(int i =0;i<s.Length;i++)
            {
                if ((int)s[i] >= 48 && (int)s[i] <= 57)
                {
                    resultString.Append((char)((int)s[i] + 32));
                }
                else if ((int)s[i]>=65 && (int)s[i] <= 90)
                {
                    resultString.Append((char)((int)s[i] + 32));
                }
                else if ((int)s[i] >= 97 && (int)s[i] <= 122)
                {
                    resultString.Append(s[i]);
                }
            }
            Console.WriteLine($"converted string {resultString}");
            return Helper.IsStringPallindrome(resultString.ToString());
        }
    }
}
