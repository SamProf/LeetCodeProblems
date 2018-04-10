using System.Text;

namespace LeetCodeProblems.P67
{
    public class Solution67
    {
        public string AddBinary(string a, string b)
        {
            var sb = new StringBuilder();

            var sum = 0;
            var i1 = a.Length - 1;
            var i2 = b.Length - 1;

            while (i1 >= 0 || i2 >= 0 || sum != 0)
            {
                if (i1 >= 0)
                {
                    sum += a[i1] - '0';
                    i1--;
                }

                if (i2 >= 0)
                {
                    sum += b[i2] - '0';
                    i2--;
                }

                sb.Insert(0, sum % 2);
                sum /= 2;
            }

            return sb.ToString();
        }
    }
}