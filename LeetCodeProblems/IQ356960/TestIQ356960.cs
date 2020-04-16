using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.IQ356960
{
    [TestFixture]
    public class TestIQ356960
    {
        [TestCaseSource(typeof(TestIQ356960), nameof(TestCases))]
        public void Test(int[] nums, int target, int[] expected)
        {
            var s = new SolutionIQ356960();
            var r = s.GivenSum(nums, target);
            Console.WriteLine(string.Join(", ", r));
            Assert.AreEqual(expected, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new int[] {1, 10, 25, 35, 60},
                90,
                new int[] {2, 3}
            };

            yield return new object[]
            {
                new int[] {20, 50, 40, 25, 30, 10},
                90,
                new int[] {1, 5}
            };
        }
    }
}