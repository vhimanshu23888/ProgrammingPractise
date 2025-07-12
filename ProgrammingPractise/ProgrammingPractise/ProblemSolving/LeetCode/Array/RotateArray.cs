namespace ProblemSolving.LeetCode.Array
{
    public class RotateArray
    {
        public int[] Rotate(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 2; j >= 0; j--)
                {
                    nums[j + 1] = nums[j];
                }
                nums[0] = temp;
            }
            return nums;
        }



    }
}