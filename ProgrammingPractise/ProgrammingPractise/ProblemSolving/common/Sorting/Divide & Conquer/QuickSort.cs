using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.common.Sorting.Divide___Conquer
{
    public class QuickSort
    {
        private int Partition(int[] input, int start, int end)
        {
            int pivot = input[end];
            int j = start - 1;
            for (int i = start; i < end; i++)
            {
                if (input[i] < pivot)
                {
                    j++;
                    swap(input, i, j);
                }
            }
            swap(input, j+1, end);
            return j;
        }
        private void swap(int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
        public void Sort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(input, low, high);
                Sort(input, low, partitionIndex - 1);
                Sort(input, partitionIndex + 1, high);
            }
        }

    }
}
