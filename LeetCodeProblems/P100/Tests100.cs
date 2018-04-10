using NUnit.Framework;

namespace LeetCodeProblems.P100
{
    [TestFixture]
    public class Tests100
    {
        [Test]
        public void Test1()
        {
            var s = new Solution100();
            Assert.AreEqual(false, s.IsSameTree(new Solution100.TreeNode(1)
            {
                left = new Solution100.TreeNode(2)
            }, new Solution100.TreeNode(1)
            {
                right = new Solution100.TreeNode(2)
            }));
        }
    }
}