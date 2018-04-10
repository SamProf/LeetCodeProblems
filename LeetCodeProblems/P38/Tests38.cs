using NUnit.Framework;

namespace LeetCodeProblems.P38
{
    [TestFixture]
    public class Tests38
    {
        [Test]
        public void Test1()
        {
            var s = new Solution38();
            Assert.AreEqual("1", s.CountAndSay(1));
            Assert.AreEqual("11", s.CountAndSay(2));
            Assert.AreEqual("21", s.CountAndSay(3));
            Assert.AreEqual("1211", s.CountAndSay(4));
            Assert.AreEqual("111221", s.CountAndSay(5));
        }
    }
}