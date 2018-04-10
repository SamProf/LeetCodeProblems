using NUnit.Framework;

namespace LeetCodeProblems.P13
{
    [TestFixture]
    public class Tests13
    {
        [Test]
        public void Test1()
        {
            var s = new Solution13();
            Assert.AreEqual(1, s.RomanToInt("I"));
            Assert.AreEqual(2, s.RomanToInt("II"));
            Assert.AreEqual(3, s.RomanToInt("III"));
            Assert.AreEqual(4, s.RomanToInt("IV"));
            Assert.AreEqual(5, s.RomanToInt("V"));
            Assert.AreEqual(6, s.RomanToInt("VI"));
            Assert.AreEqual(7, s.RomanToInt("VII"));
            Assert.AreEqual(8, s.RomanToInt("VIII"));
            Assert.AreEqual(9, s.RomanToInt("IX"));
            Assert.AreEqual(10, s.RomanToInt("X"));
            Assert.AreEqual(39, s.RomanToInt("XXXIX"));
            Assert.AreEqual(246, s.RomanToInt("CCXLVI"));
            Assert.AreEqual(207, s.RomanToInt("CCVII"));
            Assert.AreEqual(1066, s.RomanToInt("MLXVI"));
            Assert.AreEqual(1776, s.RomanToInt("MDCCLXXVI"));
        }
    }
}