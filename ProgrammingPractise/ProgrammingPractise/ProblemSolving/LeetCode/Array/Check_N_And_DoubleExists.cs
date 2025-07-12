using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving.LeetCode.Array
{
    class Check_N_And_DoubleExists
    {
        public bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (((arr[j] == arr[i] / 2) && (arr[i] % 2 == 0)) || arr[j] == arr[i] * 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CheckIfExistHashSet(int[] arr)
        {
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                hashSet.UnionWith(arr.Skip(i + 1));
                if ((hashSet.Contains(arr[i] / 2) && (arr[i] % 2 == 0)) || hashSet.Contains(arr[i] * 2))
                {
                    return true;
                }
                hashSet.Clear();
            }
            return false;
        }
    }
}
