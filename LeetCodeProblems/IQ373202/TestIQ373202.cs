using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCodeProblems.IQ373202
{
    [TestFixture]
    public class TestIQ373202
    {
        [TestCaseSource(typeof(TestIQ373202), nameof(TestCases))]
        public void Test(List<int[]> a, List<int[]> b, int target, List<int[]> expected)
        {
            var s = new SolutionIQ373202();
            var r = s.GetPairs(a, b, target);
            Console.WriteLine($"[{string.Join(", ", r.Select(i => $"[{string.Join(", ", i)}]"))}]");
            Assert.AreEqual(expected, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new List<int[]>()
                {
                    new int[] {1, 2},
                    new int[] {2, 4},
                    new int[] {3, 6},
                },
                new List<int[]>()
                {
                    new int[] {1, 2},
                },
                7,
                new List<int[]>()
                {
                    new int[] {2, 1},
                },
            };

            yield return new object[]
            {
                new List<int[]>()
                {
                    new int[] {1, 3},
                    new int[] {2, 5},
                    new int[] {3, 7},
                    new int[] {4, 10},
                },
                new List<int[]>()
                {
                    new int[] {1, 2},
                    new int[] {2, 3},
                    new int[] {3, 4},
                    new int[] {4, 5},
                },
                10,
                new List<int[]>()
                {
                    new int[] {2, 4},
                    new int[] {3, 2},
                },
            };


            yield return new object[]
            {
                new List<int[]>()
                {
                    new int[] {1, 8},
                    new int[] {2, 7},
                    new int[] {3, 14},
                },
                new List<int[]>()
                {
                    new int[] {1, 5},
                    new int[] {2, 10},
                    new int[] {3, 14},
                },
                20,
                new List<int[]>()
                {
                    new int[] {3, 1},
                },
            };

            yield return new object[]
            {
                new List<int[]>()
                {
                    new int[] {1, 8},
                    new int[] {2, 15},
                    new int[] {3, 9},
                },
                new List<int[]>()
                {
                    new int[] {1, 8},
                    new int[] {2, 11},
                    new int[] {3, 12},
                },
                20,
                new List<int[]>()
                {
                    new int[] {1, 3},
                    new int[] {3, 2},
                },
            };
        }
    }
}