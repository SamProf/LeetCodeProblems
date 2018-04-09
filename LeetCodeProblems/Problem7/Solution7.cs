using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problem7
{
    public class Solution7
    {
        public int Reverse(int x)
        {
            if (x < -1 * int.MaxValue)
            {
                return 0;
            }

            var r = 0;
            var x2 = Math.Abs(x);
            while (x2 != 0)
            {
                if (r > (int.MaxValue - (x2 % 10)) / 10)
                {
                    return 0;
                }
                r = r * 10 + (x2 % 10);
                x2 /= 10;
            }

            r *= Math.Sign(x);
            return r;
        }
    }
}