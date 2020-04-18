using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.P167
{
    [TestFixture]
    public class TestP167
    {
        [TestCaseSource(typeof(TestP167), nameof(TestCases))]
        public void Test(int[] numbers, int target, int[] expected)
        {
            var s = new SolutionP167();
            var r = s.TwoSum(numbers, target);
            Console.WriteLine(string.Join(", ", r));
            Assert.AreEqual(expected, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new int[] {2, 7, 11, 15},
                9,
                new int[] {1, 2}
            };
        }
    }
}