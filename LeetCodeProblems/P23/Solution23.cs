using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P23
{
    public class Solution23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var root = new ListNode(0);

            for (var index = 0; index < lists.Length; index++)
            {
                var list = lists[index];
                var cur = root;
                while (list != null)
                {
                    if (cur.next == null)
                    {
                        cur.next = list;
                        list = list.next;
                        cur.next.next = null;
                        cur = cur.next;
                    }
                    else
                    {
                        if (list.val > cur.next.val)
                        {
                            cur = cur.next;
                        }
                        else
                        {
                            var t = list;
                            list = list.next;
                            t.next = cur.next;
                            cur.next = t;
                        }
                    }
                }
            }


            return root.next;
        }


        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }
    }
}