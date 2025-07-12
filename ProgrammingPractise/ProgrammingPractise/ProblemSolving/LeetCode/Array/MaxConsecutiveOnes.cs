namespace ProblemSolving.LeetCode.Array
{
    class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int pointer, counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    pointer = i;
                    while (i + 1 < nums.Length && nums[i + 1] != 0)
                    {
                        i = i + 1;
                    }
                    if (counter < i - pointer + 1)
                    {
                        counter = i - pointer + 1;
                    }
                }
            }
            return counter;
        }
    }
}
