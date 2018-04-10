namespace LeetCodeProblems.P2
{
    public class Solution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var root = new ListNode(0);
            var cur = root;
            var sum = 0;
            while (l1 != null || l2 != null || sum != 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                cur.next = new ListNode(sum % 10);
                sum = (sum - cur.next.val) / 10;
                cur = cur.next;
            }

            return root.next;
        }


        public class ListNode
        {
            public ListNode next;
            public int val;

            public ListNode(int x)
            {
                val = x;
            }
        }
    }
}