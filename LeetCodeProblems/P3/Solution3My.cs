using System;

namespace LeetCodeProblems.P3
{
    public class Solution3My : ISolution3
    {
        public int LengthOfLongestSubstring(string s)
        {
            var a = new int[char.MaxValue];
            for (var i = 0; i < a.Length; i++) a[i] = -1;

            var maxLength = 0;
            var maxStart = -1;
            for (var index = 0; index < s.Length; index++)
            {
                var ch = s[index];
                var lastIndex = a[ch];
                a[ch] = index;
                var curLength = index - Math.Max(maxStart, lastIndex);
                if (curLength > maxLength) maxLength = curLength;

                if (lastIndex != -1)
                    if (lastIndex > maxStart)
                        maxStart = lastIndex;
            }

            return maxLength;
        }
    }
}