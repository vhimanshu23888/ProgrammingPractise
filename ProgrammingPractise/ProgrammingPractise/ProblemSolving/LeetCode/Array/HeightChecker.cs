using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode.Array
{
    class HeightChecker
    {
        public int HeightCheckerMethod(int[] heights)
        {
            int[] expectedHeights = new int[heights.Length];
            heights.CopyTo(expectedHeights,0);
            System.Array.Sort(expectedHeights);
            int count = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expectedHeights[i])
                    count++;
            }
            return count;
        }
    }
}
