using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCodeProblems.P763
{
    [TestFixture]
    public class TestP763
    {
        [TestCaseSource(typeof(TestP763), nameof(TestCases))]
        public void Test(string S, IList<int> expected)
        {
            var s = new SolutionP763();
            var r = s.PartitionLabels(S);
            Console.WriteLine(string.Join(" ", r));
            Assert.AreEqual(expected, r);
        }

        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                "ababcbacadefegdehijhklij",
                new List<int>() {9, 7, 8},
            };
        }
    }
}