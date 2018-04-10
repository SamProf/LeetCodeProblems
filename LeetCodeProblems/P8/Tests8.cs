using NUnit.Framework;

namespace LeetCodeProblems.P8
{
    [TestFixture]
    public class Tests8
    {
        [Test]
        public void Test1()
        {
            var s = new Solution8();
            Assert.AreEqual(1, s.MyAtoi("1"));
            Assert.AreEqual(1, s.MyAtoi("     1"));
            Assert.AreEqual(155, s.MyAtoi("     155"));
            Assert.AreEqual(155, s.MyAtoi("     +155"));
            Assert.AreEqual(-155, s.MyAtoi("     -155"));
            Assert.AreEqual(-155, s.MyAtoi("     -155aaareer"));
        }
    }
}