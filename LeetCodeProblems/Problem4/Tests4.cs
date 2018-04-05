using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCodeProblems.Problem4
{
    [TestFixture]
    public class Tests4
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, new Solution4My().FindMedianSortedArrays(new int[] {1, 3}, new int[] {2}));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(2.5, new Solution4My().FindMedianSortedArrays(new int[] {1, 2}, new int[] {3, 4}));
        }
    }
}