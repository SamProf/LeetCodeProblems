namespace LeetCodeProblems.P9
{
    public class Solution9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || x != 0 && x % 10 == 0) return false;

            var r = 0;
            while (x > r)
            {
                r = r * 10 + x % 10;
                x /= 10;
            }

            return x == r || x == r / 10;
        }
    }
}