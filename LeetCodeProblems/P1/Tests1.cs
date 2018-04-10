using NUnit.Framework;

namespace LeetCodeProblems.P1
{
    [TestFixture]
    public class Tests1
    {
        [Test]
        public void Test1()
        {
            var solver = new Solution1();
            Assert.AreEqual(new[] {0, 1}, solver.TwoSum(new[] {2, 7, 11, 15}, 9));
        }
    }
}