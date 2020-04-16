namespace LeetCodeProblems.P572
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }


    public class SolutionP572
    {
        public bool IsSubtree2(TreeNode s, TreeNode t, bool exact)
        {
            if (s == null || t == null)
            {
                return s == t;
            }

            if (s.val == t.val && IsSubtree2(s.left, t.left, true) && IsSubtree2(s.right, t.right, true))
            {
                return true;
            }

            if (!exact)
            {
                if (IsSubtree2(s.left, t, false))
                {
                    return true;
                }

                if (IsSubtree2(s.right, t, false))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            return IsSubtree2(s, t, false);
        }
    }
}