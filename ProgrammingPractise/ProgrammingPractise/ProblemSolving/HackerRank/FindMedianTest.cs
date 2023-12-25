using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class FindMedianTest
    {
        public int findMedian(List<int> arr)
        {
            //for (int i = 0; i < arr.Count - 1; i++)
            //{
            //    for (int j = i+1; j < arr.Count; j++)
            //    {
            //        int temp = 0;
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //foreach (int i in arr)
            //    Console.WriteLine(i);
            arr.Sort();
            return arr[arr.Count / 2];
        }
    }
}
