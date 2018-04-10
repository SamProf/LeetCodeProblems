using System.Linq;
using NUnit.Framework;

namespace LeetCodeProblems.P26
{
    [TestFixture]
    public class Tests26
    {
        private void Test(int[] a, int r, int[] e)
        {
            var s = new Solution26();
            Assert.AreEqual(r, s.RemoveDuplicates(a));
            Assert.AreEqual(e, a.Take(r).ToArray());
        }

        [Test]
        public void Test1()
        {
            Test(new[] {1, 1, 2}, 2, new[] {1, 2});
        }
    }
}