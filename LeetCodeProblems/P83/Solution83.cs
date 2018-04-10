namespace LeetCodeProblems.P83
{
    internal class Solution83
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return head;

            var cur = head;
            while (cur.next != null)
                if (cur.val == cur.next.val)
                    cur.next = cur.next.next;
                else
                    cur = cur.next;

            return head;
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