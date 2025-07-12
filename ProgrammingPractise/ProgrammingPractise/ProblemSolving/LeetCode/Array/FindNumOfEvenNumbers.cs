using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode.Array
{
    public class FindNumOfEvenNumbers
    {
        public int FindNumbers(int[] nums)
        {
            int result = 0;
            foreach (int number in nums)
            {
                int num = number;
                int numOfDigits = 1;
                while (num / 10 > 0)
                {
                    numOfDigits++;
                    num = num / 10;
                }
                if (numOfDigits % 2 == 0)
                    result++;
            }
            return result;
            
        }
    }
}
