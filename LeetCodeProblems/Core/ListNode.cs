using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Core
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }


    public static class ListNodeExtensions
    {
        public static ICollection<int> ToArray(this ListNode node)
        {
            var list = new List<int>();
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }

            return list;
        }

        public static ListNode ToListNode(this ICollection<int> list)
        {
            var root = new ListNode(0);
            var node = root;
            foreach (var i in list)
            {
                node.next = new ListNode(i);
                node = node.next;
            }

            return root.next;
        }
    }
}