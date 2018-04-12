using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProblems.Core;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCodeProblems.P25
{
    [TestFixture()]
    public class Tests25
    {
        [Test]
        public void Test1()
        {
            var s = new Solution25();

            Assert.AreEqual(new[] { 3, 2, 1,}, s.ReverseKGroup(new[] { 1, 2, 3, }.ToListNode(), 3).ToArray());
//            Assert.AreEqual(new[] { 3, 2, 1, 4, 5 }, s.ReverseKGroup(new[] { 1, 2, 3, 4, 5 }.ToListNode(), 3).ToArray());
//
//            Assert.AreEqual(new[] { 2, 1, }, s.ReverseKGroup(new[] { 1, 2}.ToListNode(), 2).ToArray());
//            Assert.AreEqual(new[] { 1, 2, 3, 4, 5 }, s.ReverseKGroup(new[] {1, 2, 3, 4, 5}.ToListNode(), 1).ToArray());
//            Assert.AreEqual(new[] {2, 1, 4, 3, 5}, s.ReverseKGroup(new[] {1, 2, 3, 4, 5}.ToListNode(), 2).ToArray());
            
        }
    }
}