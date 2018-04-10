using NUnit.Framework;

namespace LeetCodeProblems.P6
{
    [TestFixture]
    public class sTests6
    {
        [Test]
        public void Test1()
        {
            var s = new Solution6();
            Assert.AreEqual("0123456789", s.Convert2("0123456789", 1));
            Assert.AreEqual("0246813579", s.Convert2("0123456789", 2));
            Assert.AreEqual("0481357926", s.Convert2("0123456789", 3));
            Assert.AreEqual("0615724839", s.Convert2("0123456789", 4));
            Assert.AreEqual("0817926354", s.Convert2("0123456789", 5));


            Assert.AreEqual("PAHNAPLSIIGYIR", s.Convert("PAYPALISHIRING", 3));
        }
    }
}