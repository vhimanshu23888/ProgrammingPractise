/*
 Given an array of integers and a positive integer k, determine the number of (i,j) pairs where i<j and a[i] + a[j] is divisible by k.

Example

ar= [1,2,3,4,5,6]
k = 5
,
Three pairs meet the criteria: [1,4], [2,3] and [4,6].

Function Description

Complete the divisibleSumPairs function in the editor below.

divisibleSumPairs has the following parameter(s):

int n: the length of array 
int ar[n]: an array of integers
int k: the integer divisor
Returns
- int: the number of pairs

Input Format

The first line contains 2 space-separated integers, n and k.
The second line contains n space-separated integers, each a value of arr[i].

Constraints
2<= n <= 100
1<= k <= 100
1<= arr[i] <= 100

Sample Input

STDIN           Function
-----           --------
6 3             n = 6, k = 3
1 3 2 6 1 2     ar = [1, 3, 2, 6, 1, 2]
Sample Output

 5
Explanation

Here are the  valid pairs when :


 */


using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class DivisibleSumPairs
    {
        public int GetDivisiblePairsCount(int n, int k, List<int> ar)
        {
            int noOfDivisblePairs = 0;

            for (int i = 0; i < ar.Count - 1; i++)
            {
                for(int j = i+1; j<ar.Count;j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        noOfDivisblePairs++;
                }
            }


            return noOfDivisblePairs;
        }
    }
}