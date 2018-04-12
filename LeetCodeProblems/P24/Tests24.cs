using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProblems.Core;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCodeProblems.P24
{
    [TestFixture()]
    public class Tests24
    {
        [Test]
        public void Test1()
        {
            var s = new Solution24();
            Assert.AreEqual(new[] {2, 1, 4, 3}, s.SwapPairs(new[] {1, 2, 3, 4}.ToListNode()).ToArray());
        }
    }
}