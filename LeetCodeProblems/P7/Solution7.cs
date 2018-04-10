using System;

namespace LeetCodeProblems.P7
{
    public class Solution7
    {
        public int Reverse(int x)
        {
            if (x == int.MinValue)
            {
                return 0;
            }

            var r = 0;
            var s = Math.Sign(x);
            x = Math.Abs(x);
            while (x != 0)
            {
                var d = x % 10;
                if (r > (int.MaxValue - d) / 10)
                {
                    return 0;
                }

                r = r * 10 + d;
                x /= 10;
            }

            return r * s;
        }
    }
}