using NUnit.Framework;

namespace LeetCodeProblems.P28
{
    [TestFixture]
    public class Tests28
    {
        [Test]
        public void Test1()
        {
            var s = new Solution28();
            Assert.AreEqual(0, s.StrStr("mississippi", "mississippi"));
            Assert.AreEqual(2, s.StrStr("hello", "ll"));
            Assert.AreEqual(-1, s.StrStr("aaaaaaa", "bba"));
        }
    }
}