using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCodeProblems.P18
{
    [TestFixture()]
    public class Tests18
    {
        [Test]
        public void Test1()
        {
            var res = new Solution18().FourSum(new[] {1, 0, -1, 0, -2, 2}, 0);
            Assert.AreEqual(3,res.Count);

                
            res = new Solution18().FourSum(new[] { -3, -1, 0, 2, 4, 5 }, 0);
            Assert.AreEqual(1,res.Count);
            
        }
    }
}
