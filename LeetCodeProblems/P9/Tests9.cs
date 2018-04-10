using NUnit.Framework;

namespace LeetCodeProblems.P9
{
    [TestFixture]
    public class Tests9
    {
        [Test]
        public void Test1()
        {
            var s = new Solution9();
            Assert.AreEqual(true, s.IsPalindrome(2));
            Assert.AreEqual(true, s.IsPalindrome(121));
            Assert.AreEqual(false, s.IsPalindrome(123));
            Assert.AreEqual(true, s.IsPalindrome(84548));
            Assert.AreEqual(true, s.IsPalindrome(845548));
            Assert.AreEqual(false, s.IsPalindrome(825548));
        }
    }
}