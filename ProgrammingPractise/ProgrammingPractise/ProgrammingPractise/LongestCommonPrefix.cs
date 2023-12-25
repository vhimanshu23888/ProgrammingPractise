/*
 Problem
Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.

 */


namespace ProgrammingPractise
{
    internal class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;
            
            if (strs.Length < 1 || strs.Length > 200)
            {
                return "";
            }
            int minStringLength = strs[0].Length;
            foreach (string str in strs)
            {
                if (str.Length > 200 && str.Any(c => Char.IsUpper(c)))
                    return "";
                if(minStringLength > str.Length)
                    minStringLength = str.Length;
            }
            for(int i = 0;i < minStringLength; i++)
            {
                char currentChar = strs[0].ToCharArray()[i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (currentChar != strs[j][i])
                        return result;
                }
                result += currentChar.ToString();
            }
            return result;
        }
    }
}
/*
Test
//LongestCommonPrefix LCF = new LongestCommonPrefix();
//string[] input = new string[] { "flower", "flow", "flight" }; Output: "fl"
//string[] input = new string[] { "dog", "racecar", "car" }; //Output: ""
//string[] input = new string[] { "cir", "car" }; Output: "c"
//string[] input = new string[] { "flower", "flower", "flower", "flower" }; //Output: "flower"
//string result = LCF.GetLongestCommonPrefix(input); 
//Console.WriteLine(string.IsNullOrEmpty(result) ? "Empty" : result);
//Console.ReadKey();

Results : Success
Details 
Runtime: 100 ms, faster than 81.73% of C# online submissions for Longest Common Prefix.
Memory Usage: 40 MB, less than 24.95% of C# online submissions for Longest Common Prefix.
*/