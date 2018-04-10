using NUnit.Framework;

namespace LeetCodeProblems.P35
{
    [TestFixture]
    public class Tests35
    {
        [Test]
        public void Test1()
        {
            var s = new Solution35();
            Assert.AreEqual(2, s.SearchInsert(new[] {1, 3, 5, 6}, 5));
            Assert.AreEqual(1, s.SearchInsert(new[] {1, 3, 5, 6}, 2));
            Assert.AreEqual(4, s.SearchInsert(new[] {1, 3, 5, 6}, 7));
            Assert.AreEqual(0, s.SearchInsert(new[] {1, 3, 5, 6}, 0));
        }
    }
}