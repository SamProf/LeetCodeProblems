using NUnit.Framework;

namespace LeetCodeProblems.P67
{
    [TestFixture]
    public class Tests67
    {
        [Test]
        public void Test1()
        {
            var s = new Solution67();
            Assert.AreEqual("100", s.AddBinary("11", "1"));
        }
    }
}