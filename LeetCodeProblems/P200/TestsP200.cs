using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCodeProblems.P200
{
    [TestFixture]
    public class TestsP200
    {
        [TestCaseSource(typeof(TestsP200), nameof(TestSource))]
        public void Test(char[][] grid, int result)
        {
            var s = new SolutionP200();
            var r = s.NumIslands(grid);
            Console.WriteLine(r);
            Assert.AreEqual(r, result);
        }


        static IEnumerable<object[]> TestSource()
        {
            yield return new object[]
            {
                new[]
                {
                    "11110".ToArray(),
                    "11010".ToArray(),
                    "11000".ToArray(),
                    "00000".ToArray(),
                },
                1
            };


            yield return new object[]
            {
                new[]
                {
                    "11000".ToArray(),
                    "11000".ToArray(),
                    "00100".ToArray(),
                    "00011".ToArray(),
                },
                3
            };
        }
    }
}