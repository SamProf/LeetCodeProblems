using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCodeProblems.P763
{
    public class SolutionP763
    {
        public IList<int> PartitionLabels(string S)
        {
            var ranges = new List<int>();
            var symbolsPos = new int['z' - 'a' + 1];
            for (int i = 0; i < S.Length; i++)
            {
                var code = S[i] - 'a';
                var charPos = symbolsPos[code];
                if (charPos > 0)
                {
                    var rangeIndex = ranges.BinarySearch(charPos - 1);

                    if (rangeIndex < 0)
                    {
                        rangeIndex = (~rangeIndex) - 1;
                    }

                    if (rangeIndex + 1 < ranges.Count)
                    {
                        ranges.RemoveRange(rangeIndex + 1, ranges.Count() - rangeIndex - 1);
                    }
                }
                else
                {
                    symbolsPos[code] = i + 1;
                    ranges.Add(i);
                }
            }


            ranges.RemoveAt(0);
            ranges.Add(S.Length);
            var prev = 0;
            var result = new List<int>();
            foreach (var range in ranges)
            {
                result.Add(range - prev);
                prev = range;
            }

            return result;
        }
    }
}