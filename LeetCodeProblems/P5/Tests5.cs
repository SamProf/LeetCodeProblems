using NUnit.Framework;

namespace LeetCodeProblems.P5
{
    [TestFixture]
    public class Tests5
    {
        [Test]
        public void Test1()
        {
            var s = new Solution5();
            Assert.AreEqual("bab", s.LongestPalindrome("babad"));
            Assert.AreEqual("bb", s.LongestPalindrome("cbbd"));
        }
    }
}