using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems.P692
{
    public class SolutionP692
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var dic = new Dictionary<string, int>();
            for (int i = 0, len = words.Length; i < len; i++)
            {
                int c;
                if (!dic.TryGetValue(words[i], out c))
                {
                    c = 0;
                }

                dic[words[i]] = c + 1;
            }

            var set = new SortedSet<KeyValuePair<string, int>>(Comparer<KeyValuePair<string, int>>.Create((v1, v2) =>
            {
                return (v2.Value == v1.Value) ? v1.Key.CompareTo(v2.Key) : v2.Value - v1.Value;
            }));

            foreach (var i in dic)
            {
                set.Add(i);
                if (set.Count > k)
                {
                    set.Remove(set.Max);
                }
            }
            return set.Select(i=>i.Key).ToList();
        }


        public IList<string> TopKFrequent_Old(string[] words, int k)
        {
            return words
                .GroupBy(i => i)
                .ToDictionary(i => i.Key, i => i.Count())
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .Take(k)
                .Select(i => i.Key)
                .ToList();
        }
    }
}