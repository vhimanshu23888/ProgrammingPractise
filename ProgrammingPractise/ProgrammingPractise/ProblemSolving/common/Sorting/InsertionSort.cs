namespace ProblemSolving.common.Sorting
{
    public class InsertionSort
    {
        public int[] Sort(int[] input)
        {
            for (int i = 1; i < input.Length - 1; i++)
            {
                int key = input[i];
                int j = i - 1;

                while (j>=0 && input[j] > key)
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }
                input[j + 1] = key;
            }
            return input;
        }
    }
}
