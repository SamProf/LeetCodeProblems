using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace LeetCodeProblems.P12
{
    [TestFixture()]
    public class Tests12
    {
        [Test]
        public void Test1()
        {
            var s = new Solution12();
            Assert.AreEqual("I", s.IntToRoman(1));
            Assert.AreEqual("II", s.IntToRoman(2));
            Assert.AreEqual("III", s.IntToRoman(3));
            Assert.AreEqual("IV", s.IntToRoman(4));
            Assert.AreEqual("V", s.IntToRoman(5));
            Assert.AreEqual("VI", s.IntToRoman(6));
            Assert.AreEqual("VII", s.IntToRoman(7));
            Assert.AreEqual("VIII", s.IntToRoman(8));
            Assert.AreEqual("IX", s.IntToRoman(9));
            Assert.AreEqual("X", s.IntToRoman(10));
            Assert.AreEqual("XXXIX", s.IntToRoman(39));
            Assert.AreEqual("CCXLVI", s.IntToRoman(246));
            Assert.AreEqual("CCVII", s.IntToRoman(207));
            Assert.AreEqual("MLXVI", s.IntToRoman(1066));
            Assert.AreEqual("MDCCLXXVI", s.IntToRoman(1776));
        }
    }
}