using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode.Array
{
    public class PascalsTriangle2
    {
        public IList<int> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>() { 1 });
            for (int i = 1; i < numRows+1; i++)
            {
                int p1 = 0; int p2 = 1;
                int[] temp = new int[i + 1];
                temp[0] = 1;temp[i] = 1;

                for (int k = 1; k < temp.Length - 1; k++)
                {
                    temp[k] = result[i - 1][p1] + result[i - 1][p2];
                    p1++; p2++;
                }
                List<int> tempList = new List<int>();
                tempList.AddRange(temp);
                result.Add(tempList);
            }
            return result[numRows];
        }
    }
}
