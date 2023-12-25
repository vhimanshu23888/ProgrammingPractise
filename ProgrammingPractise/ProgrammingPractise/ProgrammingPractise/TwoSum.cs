/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:
2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
*/
namespace ProgrammingPractise
{
    internal class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            //validations
            if(nums.Length < 2 || nums.Length > Math.Pow(10,4))
                return null;
            foreach (int num in nums)
                if (target <= Math.Pow(-10, 9) || target >= Math.Pow(10, 9))
                    return null;
            if (target <= Math.Pow(-10, 9) || target >= Math.Pow(10,9))
                return null;


            for (int i = 0;i<nums.Length-1;i++)
            {
                for(int j = i+1;j<nums.Length;j++)
                {
                    if(nums[i] + nums[j] == target)
                        return new int[]{i,j};
                }
            }
        return null;
        }

    }
}

/*
 * Test
 TwoSum twoSum = new TwoSum();

//int[] input = { 3, 2, 4 };target = 6
//int[] input = { 3, 3 }; target = 9
int[] input = { 2, 7, 11, 15 };
int[] result = twoSum.TwoSums(input, 9);

if (result != null)
{
    Console.WriteLine($"[{result[0]},{result[1]}]");
    Console.ReadKey();
}
 */


/*
Result : Success
Details 
Runtime: 176 ms, faster than 75.79% of C# online submissions for Two Sum.
Memory Usage: 44.4 MB, less than 18.27% of C# online submissions for Two Sum.
    */
