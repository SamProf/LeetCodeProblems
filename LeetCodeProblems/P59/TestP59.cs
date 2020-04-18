using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCodeProblems.P59
{
    [TestFixture]
    public class TestP59
    {
        [TestCaseSource(typeof(TestP59), nameof(TestCases))]
        public void Test(int n)
        {
            var s = new SolutionP59();
            var r = s.GenerateMatrix(n);
            Console.WriteLine(string.Join("\r\n", r.Select(i => string.Join("\t", i))));
        }

        [TestCaseSource(typeof(TestP59), nameof(TestCases))]
        public void Test_Old(int n)
        {
            var s = new SolutionP59();
            var r = s.GenerateMatrixOld(n);
            Console.WriteLine(string.Join("\r\n", r.Select(i => string.Join("\t", i))));
        }

        static IEnumerable<object[]> TestCases()
        {
            for (var i = 0; i < 10; i++)
            {
                yield return new object[]
                {
                    i
                };
            }
        }
    }
}