using System;
using NUnit.Framework;

namespace LeetCodeProblems.P692
{
    [TestFixture]
    public class TestsP692
    {
        [Test]
        public void Example1()
        {
            var s = new SolutionP692();
            var result = s.TopKFrequent(new[] {"i", "love", "leetcode", "i", "love", "coding"}, 2);
            Console.WriteLine(string.Join(" ", result));
            Assert.AreEqual(result, new string[] {"i", "love"});
        }


        [Test]
        public void Example2()
        {
            var s = new SolutionP692();
            var result = s.TopKFrequent(new[] {"the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is"},
                4);
            Console.WriteLine(string.Join(" ", result));
            Assert.AreEqual(result, new string[] {"the", "is", "sunny", "day"});
        }
    }
}