using NUnit.Framework;

namespace LeetCodeProblems.P69
{
    [TestFixture]
    public class Tests69
    {
        [Test]
        public void Tests1()
        {
            var s = new Solution69();
            Assert.AreEqual(46339, s.MySqrt(2147395599));
            Assert.AreEqual(2, s.MySqrt(4));
            Assert.AreEqual(2, s.MySqrt(8));
        }
    }
}