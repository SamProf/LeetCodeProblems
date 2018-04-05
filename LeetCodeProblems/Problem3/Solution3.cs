using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problem3
{
    public class Solution3 : ISolution3
    {
        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();
            int max = 0, i = 0, j = 0, len = s.Length;

            while (j < len)
            {
                var ch = s[j];
                if (set.Contains(ch))
                {
                    set.Remove(s[i++]);
                }
                else
                {
                    set.Add(s[j++]);
                    max = Math.Max(max, j - i);
                }
            }

            return max;
        }
    }
}