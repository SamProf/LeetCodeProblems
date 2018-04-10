using NUnit.Framework;

namespace LeetCodeProblems.P4
{
    [TestFixture]
    public class Tests4
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, new Solution4My().FindMedianSortedArrays(new[] {1, 3}, new[] {2}));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(2.5, new Solution4My().FindMedianSortedArrays(new[] {1, 2}, new[] {3, 4}));
        }
    }
}