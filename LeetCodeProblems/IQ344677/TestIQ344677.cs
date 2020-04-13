using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.IQ344677
{
    [TestFixture]
    public class TestIQ344677
    {
        [TestCaseSource(typeof(TestIQ344677), nameof(TestCases))]
        public void Test(List<int> ropes, int expected)
        {
            var s = new SolutionIQ344677();
            var r = s.MinCost(ropes);
            Console.WriteLine(r);
            Assert.AreEqual(expected, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new List<int>() {8, 4, 6, 12},
                58
            };

            yield return new object[]
            {
                new List<int>() {20, 4, 8, 2},
                54
            };

            yield return new object[]
            {
                new List<int>() {1, 2, 5, 10, 35, 89},
                224
            };

            yield return new object[]
            {
                new List<int>() {2, 2, 3, 3},
                20
            };
        }
    }
}