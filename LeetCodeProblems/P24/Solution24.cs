using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProblems.Core;

namespace LeetCodeProblems.P24
{
    public class Solution24
    {
        public ListNode SwapPairs(ListNode head)
        {
            var root = new ListNode(0)
            {
                next = head
            };
            var cur = root;


            while (cur.next != null && cur.next.next != null)
            {
                var t = cur.next;
                cur.next = cur.next.next;
                t.next = cur.next.next;
                cur.next.next = t;
                cur = cur.next.next;
            }

            return root.next;
        }
    }
}