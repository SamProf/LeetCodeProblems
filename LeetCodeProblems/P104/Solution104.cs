using System;

namespace LeetCodeProblems.P104
{
    internal class Solution104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }


        public class TreeNode
        {
            public TreeNode left;
            public TreeNode right;
            public int val;

            public TreeNode(int x)
            {
                val = x;
            }
        }
    }
}