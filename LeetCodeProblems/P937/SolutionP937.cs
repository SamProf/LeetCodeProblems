using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems.P937
{
    public class SolutionP937
    {
        struct LogLine
        {
            public int Type;
            public int Index;
            public int Start;
        }

        public string[] ReorderLogFiles(string[] logs)
        {
            var logLines = new LogLine[logs.Length];

            for (var index = 0; index < logs.Length; index++)
            {
                var log = logs[index];

                logLines[index].Index = index;
                logLines[index].Start = log.IndexOf(' ') + 1;
                logLines[index].Type = char.IsDigit(log[logLines[index].Start]) ? 1 : 0;
            }


            Array.Sort(logLines, Comparer<LogLine>.Create((l1, l2) =>
            {
                var typeC = l1.Type - l2.Type;
                if (typeC != 0)
                {
                    return typeC;
                }

                if (l1.Type == 0)
                {
                    var strC = string.Compare(logs[l1.Index], l1.Start, logs[l2.Index], l2.Start, Int32.MaxValue);
                    if (strC != 0)
                    {
                        return strC;
                    }

                    return string.Compare(logs[l1.Index], 0, logs[l2.Index], 0, l1.Start - 1);
                }
                else
                {
                    return l1.Index - l2.Index;
                }
            }));

            return logLines.Select(i => logs[i.Index]).ToArray();
        }
    }
}