using System.Text;

namespace LeetCodeProblems.P38
{
    public class Solution38
    {
        public string CountAndSay(int n)
        {
            var s = new StringBuilder("1");
            for (var i = 1; i < n; i++)
            {
                var s2 = new StringBuilder();

                int count;
                for (var j = 0; j < s.Length; j += count)
                {
                    count = 1;
                    for (var k = j + 1; k < s.Length; k++)
                    {
                        if (s[j] != s[k]) break;

                        count++;
                    }

                    s2.Append(count).Append(s[j]);
                }

                s = s2;
            }

            return s.ToString();
        }
    }
}