using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.common.Sorting
{
    public class BubbleSort
    {
       public int[] Sort(int[] input)
        {
            for(int i =0; i< input.Length-1;i++)
            {
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if(input[j +1] < input[j])
                    {
                        int temp = input[j];
                        input [j] = input[j+1];
                        input [j+1] = temp;
                    }
                }
            }

            return input;
        }
    }
}
