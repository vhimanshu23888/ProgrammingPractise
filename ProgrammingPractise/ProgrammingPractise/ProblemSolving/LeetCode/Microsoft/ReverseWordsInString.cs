using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode.Microsoft
{
    public class ReverseWordsInString
    {
        public string ReverseWords(string s)
        {
            string[] arrayStrings = s.Trim().Split(' ');
            int front = 0;int rear = arrayStrings.Length - 1;

            while(front<rear)
            {
                //while (string.IsNullOrWhiteSpace(arrayStrings[front]) && front < rear)
                //    front++;
                //while (string.IsNullOrWhiteSpace(arrayStrings[rear]) && front < rear)
                //    rear--;
                string temp = arrayStrings[front];
                arrayStrings[front] = arrayStrings[rear];
                arrayStrings[rear] = temp;

                front++;
                rear--;
            }
            string result = string.Empty;
            foreach(string str in arrayStrings)
            {
                if (!string.IsNullOrWhiteSpace(str))
                    result = result + str + " ";
            }
            return result.Trim();
        }
    }
}
