using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.IQ411357
{
    [TestFixture]
    public class TestIQ411357
    {
        private void Test(ISolutionIQ411357 s, int rows, int columns, List<List<int>> grid, int result)
        {
            var result2 = s.MinHours(rows, columns, grid);
            Console.WriteLine(result2);
            Assert.AreEqual(result, result2);
        }


        [Test]
        public void Example1()
        {
            Test(new SolutionIQ411357(), 4, 5, new List<List<int>>()
            {
                new List<int>()
                {
                    0, 1, 1, 0, 1
                },
                new List<int>()
                {
                    0, 1, 0, 1, 0
                },
                new List<int>()
                {
                    0, 0, 0, 0, 1
                },
                new List<int>()
                {
                    0, 1, 0, 0, 0
                },
            }, 2);
        }
        
        [Test]
        public void Example1_BSF()
        {
            Test(new SolutionIQ411357_NOT_MY_BSF(), 4, 5, new List<List<int>>()
            {
                new List<int>()
                {
                    0, 1, 1, 0, 1
                },
                new List<int>()
                {
                    0, 1, 0, 1, 0
                },
                new List<int>()
                {
                    0, 0, 0, 0, 1
                },
                new List<int>()
                {
                    0, 1, 0, 0, 0
                },
            }, 2);
        }
    }
}