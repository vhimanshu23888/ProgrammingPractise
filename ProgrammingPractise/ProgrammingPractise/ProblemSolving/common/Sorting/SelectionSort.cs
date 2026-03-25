namespace ProblemSolving.common.Sorting
{
    public class SelectionSort
    {
        public int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i; j < input.Length - 1; j++)
                {
                    if (input[j] < input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            return input;
        }
    }
}
