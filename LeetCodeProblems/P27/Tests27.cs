using System.Linq;
using NUnit.Framework;

namespace LeetCodeProblems.P27
{
    [TestFixture]
    public class Tests27
    {
        private void Test(int[] a, int ar, int r, int[] e)
        {
            var s = new Solution27();
            Assert.AreEqual(r, s.RemoveElement(a, ar));
            Assert.AreEqual(e, a.Take(r).ToArray());
        }

        [Test]
        public void Test1()
        {
            Test(new[] {3, 2, 2, 3}, 3, 2, new[] {2, 2});
        }
    }
}