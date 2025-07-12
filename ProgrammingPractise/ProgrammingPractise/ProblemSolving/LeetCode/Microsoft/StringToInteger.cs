using System;
using System.Collections.Generic;
using System.Text;

/*
  String to Integer (atoi)

Solution
Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

The algorithm for myAtoi(string s) is as follows:

Read in and ignore any leading whitespace.
Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either. 
This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
Read in next the characters until the next non-digit character or the end of the input is reached. The rest of the string is ignored.
Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0. 
Change the sign as necessary (from step 2).
If the integer is out of the 32-bit signed integer range [-2^31, 2^31 - 1], then clamp the integer so that it remains in the range.
Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
Return the integer as the final result.
Note:

Only the space character ' ' is considered a whitespace character.
Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.

Example 1:

Input: s = "42"
Output: 42
Explanation: The underlined characters are what is read in, the caret is the current reader position.
Step 1: "42" (no characters read because there is no leading whitespace)
         ^
Step 2: "42" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "42" ("42" is read in)
           ^
The parsed integer is 42.
Since 42 is in the range [-231, 231 - 1], the final result is 42.
Example 2:

Input: s = "   -42"
Output: -42
Explanation:
Step 1: "   -42" (leading whitespace is read and ignored)
            ^
Step 2: "   -42" ('-' is read, so the result should be negative)
             ^
Step 3: "   -42" ("42" is read in)
               ^
The parsed integer is -42.
Since -42 is in the range [-231, 231 - 1], the final result is -42.
Example 3:

Input: s = "4193 with words"
Output: 4193
Explanation:
Step 1: "4193 with words" (no characters read because there is no leading whitespace)
         ^
Step 2: "4193 with words" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "4193 with words" ("4193" is read in; reading stops because the next character is a non-digit)
             ^
The parsed integer is 4193.
Since 4193 is in the range [-231, 231 - 1], the final result is 4193.
 

Constraints:

0 <= s.length <= 200
s consists of English letters (lower-case and upper-case), digits (0-9), ' ', '+', '-', and '.'.
 */
namespace ProblemSolving.LeetCode.Microsoft
{
    class StringToInteger
    {
        //public int MyAtoi(string s)
        //{
        //    int rear = 0;
        //    bool isNegative = false;
        //    for(int i=0;i<s.Length;i++)
        //    {
        //        if(s[i] == ' ' && rear==0)
        //        {
        //            while(s[i]!= ' ')
        //            {
        //                i++;
        //                rear++;
        //            }
        //            if (s[i] == '-')
        //            {
        //                isNegative = true;
        //                rear++;
        //            }

        //        }
        //        if(s[i] == '-' && rear == -1)
        //        {
        //            isNegative = true;
        //        }
        //        else if((int)s[i] >= 48 && (int)s[i] <= 57)
        //        {
        //            if (rear == -1)
        //                rear = i;
        //        }
        //        else
        //        {
        //            if (rear == -1)
        //                return rear;
        //            return (isNegative) ? ((-1 * Convert.ToInt64(s.Substring(rear, i - rear)) < int.MinValue) ? int.MinValue : -1 * Convert.ToInt32(s.Substring(rear, i - rear)))
        //                : (Convert.ToInt64(s.Substring(rear, i - rear)) > int.MaxValue) ? int.MaxValue : Convert.ToInt32(s.Substring(rear, i - rear));
        //        }
        //        if(i == s.Length - 1)
        //        {
        //            if (rear == -1)
        //                return rear;
        //            else if (i == rear) 
        //                return (isNegative) ? -1 * Convert.ToInt32(s.Substring(i, 1)): Convert.ToInt32(s.Substring(i, 1));
        //            i++;
        //            return (isNegative) ?  ((-1 * Convert.ToInt64(s.Substring(rear, i - rear)) < int.MinValue) ? int.MinValue : -1* Convert.ToInt32(s.Substring(rear, i - rear)))
        //                : (Convert.ToInt64(s.Substring(rear, i - rear)) > int.MaxValue) ? int.MaxValue : Convert.ToInt32(s.Substring(rear, i - rear));
        //        }
        //    }
        //    return 0;
        //}
        public int MyAtoi(string ss)
        {
            int rear = -1;
            bool isNegative = false;
            bool isRead = false;
            string s = ss.Trim();

            for (int i= 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && rear == -1 && !isRead)
                {

                }
                else if (s[i] == '+' && !isRead) { isRead = true; }
                else if (s[i] == '-' && !isRead)
                {
                    isRead = true;
                    isNegative = true;
                }
                else if ((int)s[i] >= 48 && (int)s[i] <= 57)
                {
                        isRead = true;
                        if (rear == -1 && s[i] != '0')
                        rear = i;
                }
                else
                {
                    if (rear == -1)
                        return 0;
                    return GetResult(s.Substring(rear, i - rear),isNegative);
                }
                if (i == s.Length - 1)
                {
                    if (rear == -1)
                        return 0;
                    else if (i == rear)
                        return GetResult(s.Substring(i, 1), isNegative);
                    i++;
                    return GetResult(s.Substring(rear, i - rear), isNegative);
                }
            }
            return 0;
        }
        private int GetResult(string s, bool isNegative)
        {
            if (s.Length > 10)
            {
                if (isNegative)
                    return int.MinValue;
                else
                    return int.MaxValue;
            }
            else
            {
                if (isNegative)
                {
                    return (-1 * Convert.ToInt64(s) <= int.MinValue) ? int.MinValue : (-1 * Convert.ToInt32(s));
                }
                else
                    return (Convert.ToInt64(s) >= int.MaxValue) ? int.MaxValue : (Convert.ToInt32(s));
            }
        }

    }
}
