using NUnit.Framework;

namespace LeetCodeProblems.P58
{
    [TestFixture]
    public class Tests58
    {
        [Test]
        public void Test1()
        {
            var s = new Solution58();
            Assert.AreEqual(5, s.LengthOfLastWord("Hello World"));
        }
    }
}