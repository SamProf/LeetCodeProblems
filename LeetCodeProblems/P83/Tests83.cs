using NUnit.Framework;

namespace LeetCodeProblems.P83
{
    [TestFixture]
    public class Tests83
    {
        protected void Test(int[] a, int[] e)
        {
            var list = new Solution83.ListNode(0);
            var cur = list;
            foreach (var i in a)
            {
                cur.next = new Solution83.ListNode(i);
                cur = cur.next;
            }

            var res = new Solution83().DeleteDuplicates(list.next);
            foreach (var i in e)
            {
                Assert.NotNull(res);
                Assert.AreEqual(i, res.val);
                res = res.next;
            }
        }

        [Test]
        public void Test1()
        {
            Test(new[] {1, 1, 2}, new[] {1, 2});
            Test(new[] {1, 1, 2, 3, 3}, new[] {1, 2, 3});
        }
    }
}