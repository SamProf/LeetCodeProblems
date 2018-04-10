using System;

namespace LeetCodeProblems.P5
{
    public class Solution5
    {
        public string LongestPalindrome(string s)
        {
            var maxLength = 0;
            var maxI = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var curLength = Math.Max(TestPalindrome(s, i, i), TestPalindrome(s, i, i + 1));
                if (curLength > maxLength)
                {
                    maxLength = curLength;
                    maxI = i - (curLength - 1) / 2;
                }
            }

            return s.Substring(maxI, maxLength);
        }


        private int TestPalindrome(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }

            return r - l - 1;
        }
    }
}