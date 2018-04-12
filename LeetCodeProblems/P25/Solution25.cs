using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProblems.Core;
using NUnit.Framework;

namespace LeetCodeProblems.P25
{
    public class Solution25
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            throw new Exception();
//            return Rec(head, k, k);

//            var root = new ListNode(0)
//            {
//                next = head
//            };
//
//
//            var curRoot = root;
//
//
//
//            return root.next;
        }


//        public ListNode Rec(ListNode node, int k, int k1)
//        {
//            if (node == null)
//            {
//                return null;
//            }
//
//            if (k1 == 1)
//            {
//                node.next = Rec(node.next, k, k);
//                return node;
//            }
//
//            var node2 = Rec(node.next, k, k1 - 1);
//            if (node2 == null)
//            {
//                return node;
//            }
//
//            var t = node2.next;
//            node2.next = node;
//            node.next = t;
//            return node2;
//        }
    }
}