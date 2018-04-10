using NUnit.Framework;

namespace LeetCodeProblems.P2
{
    [TestFixture()]
    public class Tests2
    {
        [Test]
        public void Test1()
        {
            var solver = new Solution2();

            var input1 = new Solution2.ListNode(2)
            {
                next = new Solution2.ListNode(4)
                {
                    next = new Solution2.ListNode(3)
                }
            };
            var input2 = new Solution2.ListNode(5)
            {
                next = new Solution2.ListNode(6)
                {
                    next = new Solution2.ListNode(4)
                }
            };

            var expected = new Solution2.ListNode(7)
            {
                next = new Solution2.ListNode(0)
                {
                    next = new Solution2.ListNode(8)
                }
            };

            var result = solver.AddTwoNumbers(input1, input2);

            while (expected != null)
            {
                Assert.IsNotNull(result);
                Assert.AreEqual(expected.val, result.val);
                result = result.next;
                expected = expected.next;
            }
        }
    }
}