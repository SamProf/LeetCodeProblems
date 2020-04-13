using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.IQ347457
{
    [TestFixture]
    public class TestIQ347457
    {
        [TestCaseSource(typeof(TestIQ347457), nameof(TestCases))]
        public void Test(char[][] map, int expected)
        {
            var s = new SolutionIQ347457();
            var r = s.TreasureIsland(map);
            Console.WriteLine(r);
            Assert.AreEqual(expected, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            // for (var i = 0; i < 100; i++)
            {
                yield return new object[]
                {
                    new char[][]
                    {
                        new char[] {'O', 'O', 'O', 'O'},
                        new char[] {'D', 'O', 'D', 'O'},
                        new char[] {'O', 'O', 'O', 'O'},
                        new char[] {'X', 'D', 'D', 'O'},
                    },
                    5
                };
            }
        }
    }
}