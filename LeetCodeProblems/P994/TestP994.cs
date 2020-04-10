using System;
using NUnit.Framework;

namespace LeetCodeProblems.P994
{
    [TestFixture]
    public class TestP994
    {
        private void Test(int[][] grid, int result)
        {
            var s = new SolutionP994();
            var r = s.OrangesRotting(grid);
            Console.WriteLine(r);
            Assert.AreEqual(result, r);
        }


        [Test]
        public void Example1()
        {
            Test(new[]
            {
                new[] {2, 1, 1},
                new[] {1, 1, 0},
                new[] {0, 1, 1},
            }, 4);
        }


        [Test]
        public void Example2()
        {
            Test(new[]
            {
                new[] {2, 1, 1},
                new[] {0, 1, 1},
                new[] {1, 0, 1},
            }, -1);
        }

        [Test]
        public void Example3()
        {
            Test(new[]
            {
                new[] {0, 2},
            }, 0);
        }
    }
}