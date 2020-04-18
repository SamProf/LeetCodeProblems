using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCodeProblems.AMZ1
{
    [TestFixture]
    public class TestAMZ1
    {
        [TestCaseSource(typeof(TestAMZ1), nameof(TestCases))]
        public void Test(object expected)
        {
            var s = new SolutionAMZ1();
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