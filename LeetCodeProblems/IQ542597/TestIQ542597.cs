using System;
using NUnit.Framework;

namespace LeetCodeProblems.IQ542597
{
    [TestFixture]
    public class TestIQ542597
    {
        [Test]
        public void Example1()
        {
            var s = new SolutionIQ542597();
            var r = s.Solve(2, new[] {"anacell", "cetracular", "betacellular"}, new[]
            {
                "Anacell provides the best services in the city",
                "betacellular has awesome services",
                "Best services provided by anacell, everyone should use anacell",
            });
            Console.WriteLine(string.Join(" ", r));
            Assert.AreEqual(r, new[] {"anacell", "betacellular"});
        }


        [Test]
        public void Example2()
        {
            var s = new SolutionIQ542597();
            var r = s.Solve(2, new[] {"anacell", "betacellular", "cetracular", "deltacellular", "eurocell"}, new[]
            {
                "I love anacell Best services; Best services provided by anacell",
                "betacellular has great services",
                "deltacellular provides much better services than betacellular",
                "cetracular is worse than anacell",
                "Betacellular is better than deltacellular.",
            });
            Console.WriteLine(string.Join(" ", r));
            Assert.AreEqual(r, new[] {"betacellular", "anacell"});
        }
    }
}