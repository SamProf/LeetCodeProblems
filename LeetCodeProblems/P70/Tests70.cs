using NUnit.Framework;

namespace LeetCodeProblems.P70
{
    [TestFixture]
    public class Tests70
    {
        [Test]
        public void Test1()
        {
            var s = new Solution70();
            Assert.AreEqual(1, s.ClimbStairs(1));
            Assert.AreEqual(2, s.ClimbStairs(2));
            Assert.AreEqual(3, s.ClimbStairs(3));
            Assert.AreEqual(5, s.ClimbStairs(4));
        }
    }
}