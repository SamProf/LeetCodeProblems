using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCodeProblems.P15
{
    [TestFixture()]
    public class Tests15
    {
        [Test]
        public void TestSort()
        {
            var s = new Solution15();
            var rnd = new Random();
            var a = Enumerable.Range(0, 10).Select(i => rnd.Next(0, 10)).ToArray();
            var e = a.OrderBy(i => i).ToArray();
            s.Sort(a, 0, a.Length - 1);
            Assert.AreEqual(e, a);
        }



        [Test]
        public void Test1()
        {
            var s = new Solution15();
            var res = s.ThreeSum(new[] {-1, 0, 1, 2, -1, -4});
            Assert.AreEqual(new[]
            {
                new[] {-1, 0, 1},
                new[] {-1, -1, 2},
            }, res);
        }
    }
}