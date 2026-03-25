using ProblemSolving.common.Sorting.Divide___Conquer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode_Random
{
    internal class Easy_StringAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int sSum = 0, tSum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sSum += (int)s[i];
                tSum += (int)t[i];
            }
            return sSum == tSum;
        }
        public bool IsAnagramXOR(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int sSum = 0;int tSum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sSum ^= (int)s[i];
            }
            for (int i = 0; i < s.Length; i++)
            {
                sSum ^= (int)t[i];
            }

            return sSum == 0;
        }
        public bool IsAnagram_SortAndCompare(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] sInt = new int[s.Length];
            int[] tInt = new int[t.Length];

            for(int i = 0; i< s.Length;i++)
            {
                sInt[i] = (int)s[i];
                tInt[i] = (int)t[i];
            }

            MergeSort quickSort = new MergeSort();
            quickSort.Sort(tInt,0,tInt.Length-1);
            quickSort.Sort(sInt,0,sInt.Length-1);

            for (int i = 0;i<s.Length;i++)
            {
                if (tInt[i] != sInt[i])
                    return false;
            }
            return true;
        }
    }
}
