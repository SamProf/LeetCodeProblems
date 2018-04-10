using NUnit.Framework;

namespace LeetCodeProblems.P66
{
    [TestFixture]
    public class Tests66
    {
        [Test]
        public void Test1()
        {
            var s = new Solution66();
            Assert.AreEqual(new[] {1, 2, 3}, s.PlusOne(new[] {1, 2, 2}));
        }
    }
}