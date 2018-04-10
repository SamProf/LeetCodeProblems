namespace LeetCodeProblems.P70
{
    public class Solution70
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;

            var a1 = 1;
            var a2 = 2;

            for (var i = 2; i < n; i++)
            {
                var a3 = a1 + a2;
                a1 = a2;
                a2 = a3;
            }

            return a2;
        }
    }
}