namespace ProblemSolving.LeetCode.Array
{
    class ValidMountainArray
    {
        public bool ValidateMountainArray(int[] arr)
        {
            int peak =-1;
            if (arr.Length < 3)
                return false;
            if (arr[0] > arr[1])
                return false;

            for(int i =1;i<arr.Length-1;i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    peak = i;
                    break;
                }
                else if (arr[i] == arr[i + 1])
                    return false;
            }
            if (peak == -1)
                return false;
            else
            {
                if (peak == arr.Length - 2)
                {
                    return true;
                }
                for(int i =peak+1; i<arr.Length-1;i++)
                {
                    if (arr[i] <= arr[i + 1])
                        return false;
                }
            }


            return true;
        }
    }
}
