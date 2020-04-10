using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCodeProblems.IQ542597
{
    public class SolutionIQ542597
    {
        public string[] Solve(int k, string[] keywords, string[] reviews)
        {
            var regex = new Regex("\\w+", RegexOptions.Compiled);
            var dic = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            for (int i = 0; i < keywords.Length; i++)
            {
                dic.Add(keywords[i], 0);
            }

            foreach (var review in reviews)
            {
                var hs = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
                foreach (Match match in regex.Matches(review))
                {
                    var c = 0;
                    if (!dic.TryGetValue(match.Value, out c) || hs.Contains(match.Value))
                    {
                        continue;
                    }

                    dic[match.Value] = c + 1;
                    hs.Add(match.Value);
                }
            }
            var ss = new SortedSet<KeyValuePair<string, int>>(Comparer<KeyValuePair<string, int>>.Create((v1, v2) =>
            {
                return v1.Value == v2.Value ? v1.Key.CompareTo(v2.Key) : v2.Value - v1.Value;
            }));

            foreach (var item in dic)
            {
                ss.Add(item);
                if (ss.Count > k)
                {
                    ss.Remove(ss.Max);
                }
            }

            return ss.Select(i => i.Key).ToArray();
        }
    }
}