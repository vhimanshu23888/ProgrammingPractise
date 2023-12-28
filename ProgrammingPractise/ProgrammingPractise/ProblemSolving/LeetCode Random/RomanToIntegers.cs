/*
Problem 
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

 

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

Constraints:

1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
It is guaranteed that s is a valid roman numeral in the range [1, 3999].

*/

using System.Collections.Generic;

namespace ProgrammingPractise
{
    internal class RomanToIntegers
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> symbolValue = new Dictionary<char, int>();
            symbolValue.Add('I', 1);
            symbolValue.Add('V', 5);
            symbolValue.Add('X', 10);
            symbolValue.Add('L', 50);
            symbolValue.Add('C', 100);
            symbolValue.Add('D', 500);
            symbolValue.Add('M', 1000);

            Dictionary<string, int> pairsValue = new Dictionary<string, int>();
            pairsValue.Add("IV", 4);
            pairsValue.Add("IX", 9);
            pairsValue.Add("XL", 40);
            pairsValue.Add("XC", 90);
            pairsValue.Add("CD", 400);
            pairsValue.Add("CM", 900);

            if(s.Length < 1 || s.Length > 15)
                return -1;

            foreach (char c in s)
            {
                if (symbolValue.ContainsKey(c))
                    return -1;
            }            

            char[] input = s.ToCharArray();
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i <= input.Length - 2 && (input[i] == 'I' || input[i] == 'X' || input[i] == 'C'))
                {
                    if (pairsValue.ContainsKey($"{input[i]}{input[i + 1]}"))
                    {
                        result = result + pairsValue[$"{input[i]}{input[i + 1]}"];
                        i++;
                    }
                    else
                    {
                        result = result + symbolValue[input[i]];
                    }
                }
                else
                {
                    result = result + symbolValue[input[i]];
                }
            }
            return result;
        }
/*
 Results
Success
Details 
Runtime: 96 ms, faster than 57.47% of C# online submissions for Roman to Integer.
Memory Usage: 48.2 MB, less than 5.05% of C# online submissions for Roman to Integer.
Next challenges:
 */
        public int RomanToIntBetter(string s)
        {
            Dictionary<char, int> symbolValue = new Dictionary<char, int>();
            symbolValue.Add('I', 1);
            symbolValue.Add('V', 5);
            symbolValue.Add('X', 10);
            symbolValue.Add('L', 50);
            symbolValue.Add('C', 100);
            symbolValue.Add('D', 500);
            symbolValue.Add('M', 1000);

            if (s.Length < 1 || s.Length > 15)
                return -1;

            foreach (char c in s)
            {
                if (!symbolValue.ContainsKey(c))
                    return -1;
            }

            char[] input = s.ToCharArray();
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i <= input.Length - 2 && (symbolValue[input[i]] < symbolValue[input[i+1]]))
                {
                   result -= symbolValue[input[i]];
                }
                else
                {
                    result += symbolValue[input[i]];
                }
            }
            return result;
        }
    }
}
/*
 Test
RomanToIntegers romanToIntegers = new RomanToIntegers();
Console.WriteLine(romanToIntegers.RomanToInt("III"));
Console.WriteLine(romanToIntegers.RomanToInt("LVIII"));
Console.WriteLine(romanToIntegers.RomanToIntBetter("MCMXCIV"));
Console.ReadKey();
 */
/*
 Results
Success
Details 
Runtime: 64 ms, faster than 95.92% of C# online submissions for Roman to Integer.
Memory Usage: 48.2 MB, less than 5.05% of C# online submissions for Roman to Integer.
Next challenges:
 */