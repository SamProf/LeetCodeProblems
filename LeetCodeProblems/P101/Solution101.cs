namespace LeetCodeProblems.P101
{
    public class Solution101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return IsSymmetricEquals(root.left, root.right);
        }

        public bool IsSymmetricEquals(TreeNode a, TreeNode b)
        {
            if (a == null && b == null) return true;

            if (a == null || b == null) return false;

            return a.val == b.val && IsSymmetricEquals(a.left, b.right) && IsSymmetricEquals(a.right, b.left);
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