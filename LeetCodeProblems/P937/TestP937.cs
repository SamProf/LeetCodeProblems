using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.P937
{
    [TestFixture]
    public class TestP937
    {
        [TestCaseSource(typeof(TestP937), nameof(TestCases))]
        public void Test(string[] logs, string[] result)
        {
            var s = new SolutionP937();
            var r = s.ReorderLogFiles(logs);
            Console.WriteLine(string.Join("\r\n", r));
            Assert.AreEqual(result, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new string[] {"dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"},
                new string[] {"let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6"},
            };


            yield return new object[]
            {
                new string[] {"a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo", "a2 act car"},
                new string[]
                {
                    "a2 act car", "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7"
                },
            };
        }
    }
}