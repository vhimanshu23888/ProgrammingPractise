/*
 You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

 

Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
Example 2:

Input: nums1 = [1], m = 1, nums2 = [], n = 0
Output: [1]
Explanation: The arrays we are merging are [1] and [].
The result of the merge is [1].
Example 3:

Input: nums1 = [0], m = 0, nums2 = [1], n = 1
Output: [1]
Explanation: The arrays we are merging are [] and [1].
The result of the merge is [1].
Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
 

Constraints:

nums1.length == m + n
nums2.length == n
0 <= m, n <= 200
1 <= m + n <= 200
-10^9 <= nums1[i], nums2[j] <= 10^9
 

Follow up: Can you come up with an algorithm that runs in O(m + n) time?
 */

using System;

namespace ProblemSolving.LeetCode_Top150
{
    public class Easy_MergeSortedArray
    {
        public void Merge(ref int[] nums1, int m, int[] nums2, int n)
        {
            int num1Index = 0, num2Index = 0;
            if (nums1.Length != m + n)
                throw new Exception("Input array length is not valid.");
            if (m < 0 || n < 0 || n > 200 || m > 200)
                throw new Exception("number of elemented to be merged are not valid.");

            if (m == 0)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (nums2[i] < Math.Pow(-10, 9) || nums2[i] < Math.Pow(-10, 9))
                    {
                        throw new Exception("Invalid values of input array num2");
                    }
                }
                nums1 = nums2;
            }
            if (n == 0)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (nums1[i] < Math.Pow(-10, 9) || nums1[i] < Math.Pow(-10, 9))
                    {
                        throw new Exception("Invalid values of input array num1");
                    }
                }
                return;
            }

            while ((m + n) != (num1Index + num2Index))
            {
                if (nums1[num1Index] < Math.Pow(-10, 9) || nums1[num1Index] < Math.Pow(-10, 9)
                    || nums2[num2Index] < Math.Pow(-10, 9) || nums2[num2Index] < Math.Pow(-10, 9)
                    )
                    throw new Exception("Invalid values of input arrays");

                if (num1Index == m)
                {
                    InsertInArray(num1Index + num2Index, nums2[num2Index], ref nums1);
                    num2Index++;
                    continue;
                }
                if (num2Index == n)
                    return;
                if (nums2[num2Index] < nums1[num1Index])
                {
                    InsertInArray(num1Index + num2Index, nums2[num2Index], ref nums1);
                    num2Index++;
                }
                else
                {
                    num1Index++;
                }
            }
        }

        private void InsertInArray(int index, int value, ref int[] inputArray)
        {
            for (int i = inputArray.Length - 1; i > index; i--)
            {
                inputArray[i] = inputArray[i - 1];
            }
            inputArray[index] = value;
        }
    }


    /*
     Complexity Analysis

Time complexity: O(n+m)\mathcal{O}(n + m)O(n+m).

Same as Approach 2.

Space complexity: O(1)\mathcal{O}(1)O(1).

Unlike Approach 2, we're not using an extra array.

Proof (optional)

You might be a bit skeptical of this claim. Does it really work in every case? Is it safe to be making such a bold claim?

This way, it is guaranteed that once we start overwriting the first m values in nums1,
we will have already written each into its new position. In this way, we can eliminate the additional space.

Great question! So, why does this work? To prove it, we need to ensure that p never overwrites a value in nums1 that p1 hasn't yet read from nums1.

Words of Advice: Terrified of proofs? Many software engineers are. Good proofs are simply a series of logical assertions, each building on the next. In this way, we can go from "obvious" statements, all the way to the one we want to prove. I recommend reading each statement one by one, ensuring that you understand each before moving to the next.

We know that upon initialization, p is n steps ahead of p1 (in other words, p1 + n = p).

We also know that during each of the p iterations this algorithm performs, p is always decremented by 1, and either p1 or p2 is decremented by 1.

We can deduce that when p1 decremented, the gap between p and p1 stays the same, so there can't be an "overtake" in that case.

We can also deduce that when p2 is decremented though, the gap between p and p1 shrinks by 1 as p moves, but not p1.

And from that, we can deduce that the maximum number of times that p2 can be decremented is n. In other words, the gap between p and p1 can shrink by 1, at most n times.

In conclusion, it's impossible for an overtake to occur, as they started n apart. And when p = p1, the gap has to have shrunk n times. This means that all of nums2 have been merged in, so there is nothing more to do.
     */
    public class Easy_MergeSortedArray3PointersApproach
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Set p1 and p2 to point to the end of their respective arrays.
            int p1 = m - 1;
            int p2 = n - 1;

            // And move p backward through the array, each time writing
            // the smallest value pointed at by p1 or p2.
            for (int p = m + n - 1; p >= 0; p--)
            {
                if (p2 < 0)
                {
                    break;
                }
                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1--];
                }
                else
                {
                    nums1[p] = nums2[p2--];
                }
            }
            foreach (int i in nums1)
                Console.WriteLine(i);
        }
    }
}
