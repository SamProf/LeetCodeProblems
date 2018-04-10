namespace LeetCodeProblems.P100
{
    public class Solution100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null) return q == null && p == null;

            if (p.val != q.val) return false;

            if (!IsSameTree(p.left, q.left)) return false;

            return IsSameTree(p.right, q.right);
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