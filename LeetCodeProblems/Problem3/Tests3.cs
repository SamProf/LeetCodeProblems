using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCodeProblems.Problem3
{
    [TestFixture()]
    public class Tests3
    {
        private void Test(ISolution3 solution)
        {
            Assert.AreEqual(3, solution.LengthOfLongestSubstring("abcabcbb"));
            Assert.AreEqual(1, solution.LengthOfLongestSubstring("bbbbb"));
            Assert.AreEqual(3, solution.LengthOfLongestSubstring("pwwkew"));
        }

        [Test]
        public void Test()
        {
            Test(new Solution3());
        }

        [Test]
        public void TestMy()
        {
            Test(new Solution3My());
        }
    }
}