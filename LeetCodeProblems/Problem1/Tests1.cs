using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCodeProblems.Problem1
{
    [TestFixture]
    public class Tests1
    {
        [Test]
        public void Test1()
        {
            var solver = new Solution1();
            Assert.AreEqual(new int[] {0, 1}, solver.TwoSum(new int[] {2, 7, 11, 15}, 9));
        }
    }
}