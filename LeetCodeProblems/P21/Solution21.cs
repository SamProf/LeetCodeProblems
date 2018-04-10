namespace LeetCodeProblems.P21
{
    public class Solution21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var r = new ListNode(0);
            var c = r;
            while (true)
            {
                if (l1 != null)
                {
                    if (l2 != null)
                    {
                        if (l1.val <= l2.val)
                        {
                            c.next = l1;
                            l1 = l1.next;
                        }
                        else
                        {
                            c.next = l2;
                            l2 = l2.next;
                        }
                    }
                    else
                    {
                        c.next = l1;
                        break;
                    }
                }
                else
                {
                    c.next = l2;
                    break;
                }

                c = c.next;
            }

            return r.next;
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