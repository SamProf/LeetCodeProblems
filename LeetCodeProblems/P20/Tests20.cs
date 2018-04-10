using NUnit.Framework;

namespace LeetCodeProblems.P20
{
    [TestFixture]
    public class Tests20
    {
        public void Test1()
        {
            var s = new Solution20();
            Assert.AreEqual(true, "");
            Assert.AreEqual(true, "()");
            Assert.AreEqual(true, "{}");
            Assert.AreEqual(true, "[]");
            Assert.AreEqual(true, "([])");
            Assert.AreEqual(true, "([]){}");
            Assert.AreEqual(false, "([)]");
            Assert.AreEqual(false, "(");
        }
    }
}