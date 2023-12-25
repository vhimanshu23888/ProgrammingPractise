/*
Problem :
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
 */

namespace ProgrammingPractise
{
    internal class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length < 1 || s.Length > Math.Pow(10, 4))
                throw new Exception("Invalid String Length");

            foreach (char c in s)
            {
                if((int)c != 40 && (int)c != 41 && (int)c != 91 && (int)c != 93 && (int)c != 123 && (int)c != 125)
                    throw new Exception("Invalid Input String");
            }

            Stack<char> stackChars = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(' || s[i] == '[' || s[i] == '{')
                    stackChars.Push(s[i]);
                else
                {
                    if (stackChars.Count > 0)
                    {
                        char currentChar = stackChars.Pop();
                        if ((s[i] == ')' && currentChar != '(')
                            || (s[i] == ']' && currentChar != '[')
                            || (s[i] == '}' && currentChar != '{'))
                            return false;
                    }
                    else
                        return false;
                }
            }
            if (stackChars.Count > 0)
                return false;
            return true;
        }
    }
}
