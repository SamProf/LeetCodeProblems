using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.IQ372434
{
    [TestFixture]
    public class TestIQ372434
    {
        [TestCaseSource(typeof(TestIQ372434), nameof(TestCases))]
        public void Test(int[] nums, int target, int expected)
        {
            var s = new SolutionIQ372434();
            var r = s.Solve(nums, target);
            Console.WriteLine(r);
            Assert.AreEqual(expected, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new int[] {1, 1, 2, 45, 46, 46},
                47,
                2
            };

            yield return new object[]
            {
                new int[] {1, 1},
                2,
                1
            };

            yield return new object[]
            {
                new int[] {1, 5, 1, 5},
                6,
                1
            };
        }
    }
}