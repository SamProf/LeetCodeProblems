using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P19
{
    public class Solution19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var root = new ListNode(0)
            {
                next = head
            };


            var nodeN = root;
            var node = root.next;
            for (int i = 0; i < n; i++)
            {
                node = node.next;
            }

            while (node != null)
            {
                node = node.next;
                nodeN = nodeN.next;
            }

            nodeN.next = nodeN.next.next;

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