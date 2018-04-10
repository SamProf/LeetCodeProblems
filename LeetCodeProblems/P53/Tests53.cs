using NUnit.Framework;

namespace LeetCodeProblems.P53
{
    [TestFixture]
    public class Tests53
    {
        [Test]
        public void Test1()
        {
            var s = new Solution53();
            Assert.AreEqual(6, s.MaxSubArray(new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}));
        }
    }
}