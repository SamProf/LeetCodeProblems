using System.Collections.Generic;

namespace LeetCodeProblems.P13
{
    public class Solution13
    {
        public int RomanToInt(string s)
        {
            var dic = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            var prev = int.MaxValue;
            var sum = 0;
            foreach (var ch in s)
            {
                var cur = dic[ch];
                if (cur > prev)
                    sum += cur - prev - prev;
                else
                    sum += cur;

                prev = cur;
            }

            return sum;
        }
    }
}