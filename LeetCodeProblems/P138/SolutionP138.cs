using System.Collections.Generic;

namespace LeetCodeProblems.P138
{
// Definition for a Node.
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }


    public class SolutionP138
    {
        private Node GetNode(Dictionary<Node, Node> dic, Node node)
        {
            if (node == null)
            {
                return null;
            }

            Node node2;
            if (!dic.TryGetValue(node, out node2))
            {
                node2 = new Node(node.val);
                dic.Add(node, node2);
            }

            return node2;
        }

        public Node CopyRandomList(Node head)
        {
            var dic = new Dictionary<Node, Node>();
            Node head2 = GetNode(dic, head);
            Node node2 = head2;
            if (head != null)
            {
                do
                {
                    node2.random = GetNode(dic, head.random);
                    node2 = node2.next = GetNode(dic, head.next);
                    head = head.next;
                } while (head != null);
            }

            return head2;
        }
    }
}