using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeProblems.IQ411357;
using NUnit.Framework;

namespace LeetCodeProblems.P1268
{
    [TestFixture]
    public class TestP1268
    {
        [TestCaseSource(typeof(TestP1268), nameof(TestCases), new object[] {typeof(SolutionP1268)})]
        public void Test(Type solutionType, string[] products, string searchWord, IList<IList<string>> result)
        {
            var s = (ISolutionP1268) Activator.CreateInstance(solutionType);
            var r = s.SuggestedProducts(products, searchWord);
            Assert.AreEqual(r, result);
            Console.WriteLine(string.Join("\r\n", r.Select(l => string.Join(" ", l))));
        }


        static IEnumerable<object[]> TestCases(Type solutionType)
        {
            yield return new object[]
            {
                solutionType,
                new string[] {"mobile", "mouse", "moneypot", "monitor", "mousepad"},
                "mouse",
                new[]
                {
                    new string[] {"mobile", "moneypot", "monitor"},
                    new string[] {"mobile", "moneypot", "monitor"},
                    new string[] {"mouse", "mousepad"},
                    new string[] {"mouse", "mousepad"},
                    new string[] {"mouse", "mousepad"},
                },
            };
        }
    }
}