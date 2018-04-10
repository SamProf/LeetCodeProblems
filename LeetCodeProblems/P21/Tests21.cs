using NUnit.Framework;

namespace LeetCodeProblems.P21
{
    [TestFixture]
    public class Tests21
    {
        private void Test(int[] e, int[] a1, int[] a2)
        {
            var l1 = new Solution21.ListNode(0);
            var c1 = l1;
            foreach (var i in a1)
            {
                var n1 = new Solution21.ListNode(i);
                c1.next = n1;
                c1 = n1;
            }

            var l2 = new Solution21.ListNode(0);
            var c2 = l2;
            foreach (var i in a2)
            {
                var n2 = new Solution21.ListNode(i);
                c2.next = n2;
                c2 = n2;
            }

            var s = new Solution21();
            var r = s.MergeTwoLists(l1.next, l2.next);

            foreach (var i in e)
            {
                Assert.NotNull(s);
                Assert.AreEqual(i, r.val);
                r = r.next;
            }

            Assert.IsNull(r);
        }

        [Test]
        public void Test1()
        {
            Test(new[] {1, 1, 2, 3, 4, 4}, new[] {1, 2, 4}, new[] {1, 3, 4});
        }
    }
}