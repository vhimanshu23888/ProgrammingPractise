/*
Given an integer x, return true if x is palindrome integer.
An integer is a palindrome when it reads the same backward as forward.
For example, 121 is a palindrome while 123 is not.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

Constraints:
-2^31 <= x <= 2^31 - 1
Follow up: Could you solve it without converting the integer to a string?
 */

using System;

namespace ProgrammingPractise
{
    internal class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            if (x<Math.Pow(-10,31) || x > Math.Pow(10,31) - 1)
                return false;

            char[] numberArray = x.ToString().ToCharArray();
            int iterationCount = numberArray.Length - 1;

            if(numberArray.Length == 2)
            {
                if(numberArray[0] == numberArray[1])
                    return true;
                else
                    return false;
            }

            for (int i = 0;i<= iterationCount/2; i++)
            {
                if(numberArray[i] != numberArray[iterationCount- i])
                    return false;
            }
            return true;
        }
        /*
         Result : Success
        Details 
        Runtime: 53 ms, faster than 71.95% of C# online submissions for Palindrome Number.
        Memory Usage: 30.7 MB, less than 7.98% of C# online submissions for Palindrome Number.
         */
        public bool IsPalindromeWithoutString(int n)
        {
            if (n < 0)
                return false;
            // Find the appropriate
            // divisor to extract
            // the leading digit
            int divisor = 1;
            while (n / divisor >= 10)
                divisor *= 10;

            while (n != 0)
            {
                int leading = n / divisor;
                int trailing = n % 10;

                // If first and last digit
                // not same return false
                if (leading != trailing)
                    return false;

                // Removing the leading and
                // trailing digit from number
                n = (n % divisor) / 10;

                // Reducing divisor by
                // a factor of 2 as 2
                // digits are dropped
                divisor = divisor / 100;
            }
            return true;
        }
/*
Result : Success
Details 
Runtime: 54 ms, faster than 70.63% of C# online submissions for Palindrome Number.
Memory Usage: 29.2 MB, less than 36.51% of C# online submissions for Palindrome Number.
*/
    }
}
/*
Test Result
Palindrome palindrome = new Palindrome();
Console.WriteLine(palindrome.IsPalindrome(121));
Console.WriteLine(palindrome.IsPalindrome(-121));
Console.WriteLine(palindrome.IsPalindrome(10));
Console.WriteLine(palindrome.IsPalindrome(1000030001));
Console.WriteLine(palindrome.IsPalindromeWithoutString(-1));
Console.WriteLine("**********************************************************");
Console.WriteLine(palindrome.IsPalindromeWithoutString(121));
Console.WriteLine(palindrome.IsPalindromeWithoutString(-121));
Console.WriteLine(palindrome.IsPalindromeWithoutString(10));
Console.WriteLine(palindrome.IsPalindromeWithoutString(1000030001));
Console.WriteLine(palindrome.IsPalindromeWithoutString(-1));
Console.ReadKey();
 */