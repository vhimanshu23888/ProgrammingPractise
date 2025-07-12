using System.Numerics;
using System.Text;

namespace ProblemSolving
{

    internal class Easy_AddBinaryNumbers
    {
        public string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            int sum = 0;
            StringBuilder result = new StringBuilder();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int digit1 = (i >= 0) ? a[i] - '0' : 0;
                int digit2 = (j >= 0) ? b[j] - '0' : 0;
                sum = digit1 + digit2 + carry;
                result.Insert(0, (sum % 2));
                carry = sum / 2;
                i--;
                j--;
            }

            return result.ToString();
        }
    }
}