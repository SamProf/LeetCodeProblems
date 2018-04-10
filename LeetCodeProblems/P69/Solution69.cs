namespace LeetCodeProblems.P69
{
    public class Solution69
    {
        public int MySqrt(int x)
        {
            var l = 0;
            var r = x;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (mid != 0 && int.MaxValue / mid < mid)
                {
                    r = mid - 1;
                    continue;
                }

                var v = mid * mid;
                if (v == x) return mid;

                if (v <= x)
                    l = mid + 1;
                else
                    r = mid - 1;
            }

            return r;
        }
    }
}