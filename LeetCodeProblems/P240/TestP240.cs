using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.P240
{
    [TestFixture]
    public class TestP240
    {
        [TestCaseSource(typeof(TestP240), nameof(TestCases))]
        public void Test(int[,] matrix, int target, bool expected)
        {
            var s = new SolutionP240();
            var r = s.SearchMatrix(matrix, target);
            Console.WriteLine(r);
            Assert.AreEqual(expected, r);
        }

        static IEnumerable<object[]> TestCases()
        {
            var matrix = new int[,]
            {
                {1, 4, 7, 11, 15},
                {2, 5, 8, 12, 19},
                {3, 6, 9, 16, 22},
                {10, 13, 14, 17, 24},
                {18, 21, 23, 26, 30}
            };

            yield return new object[]
            {
                matrix,
                5,
                true
            };

            yield return new object[]
            {
                matrix,
                20,
                false
            };
        }
    }
}