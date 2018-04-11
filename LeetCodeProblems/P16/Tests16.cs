using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCodeProblems.P16
{
    [TestFixture()]
    public class Tests16
    {
        [Test]
        public void Test1()
        {
            var s = new Solution16();
            Assert.AreEqual(2, s.ThreeSumClosest(new[] {-1, 2, 1, -4}, 1));
        }
    }
}