namespace LeetCodeProblems.P8
{
    public class Solution8
    {
        public int MyAtoi(string str)
        {
            var sum = 0;
            var len = str.Length;
            var positive = true;

            var i = 0;
            while (i < len && char.IsWhiteSpace(str[i])) i++;

            if (i < len)
                if (str[i] == '+')
                {
                    i++;
                }
                else if (str[i] == '-')
                {
                    positive = false;
                    i++;
                }


            while (i < len && char.IsDigit(str[i]))
            {
                var d = str[i] - '0';
                if (positive)
                {
                    if (sum > (int.MaxValue - d) / 10)
                    {
                        sum = int.MaxValue;
                        break;
                    }

                    sum = sum * 10 + d;
                }
                else
                {
                    if (sum < (int.MinValue + d) / 10)
                    {
                        sum = int.MinValue;
                        break;
                    }

                    sum = sum * 10 - d;
                }

                i++;
            }


            return sum;
        }
    }
}