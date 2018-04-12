using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCodeProblems.P22
{
    [TestFixture]
    public class Tests22
    {
        [Test]
        public void Test1()
        {
            var s = new Solution22();
            var res = s.GenerateParenthesis(3);
            foreach (var re in res)
            {
                Console.WriteLine(re);
            }

            Assert.AreEqual(5, res.Count);
        }
    }
}