using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.AMZ2
{
    [TestFixture]
    public class TestAMZ2
    {
        [TestCaseSource(typeof(TestAMZ2), nameof(TestCases))]
        public void Test(object expected)
        {
            var s = new SolutionAMZ2();
            var r = s.Solution();
            Console.WriteLine(r);
            Assert.AreEqual(expected, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                null
            };
        }
    }
}