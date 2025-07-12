
namespace ProblemSolving.LeetCode.Array
{
    public class PlusOne
    {
        public int[] IncrementArray(int[] digits)
        {
            if(digits.Length == 1)
            {
                if(digits[0] < 9)
                {
                    digits[0] = digits[0] + 1;
                    return digits;
                }
                else
                {
                    return new int[] { 1, 0 };
                }
            }

            if (digits[digits.Length - 1] < 9)
            {
                digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
                return digits;
            }

            for (int i = digits.Length - 2; i >= 0; i--)
            {
                if (digits[i] == 9 && i > 0)
                    continue;
                else if (digits[i] == 9 && i == 0)
                {
                    int[] result = new int[digits.Length + 1];
                    result[0] = 1;
                    return result;
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    for (int j = i + 1; j <= digits.Length - 1; j++)
                    {
                        digits[j] = 0;
                    }
                    return digits;
                }
            }
            return digits;
        }
    }
}
