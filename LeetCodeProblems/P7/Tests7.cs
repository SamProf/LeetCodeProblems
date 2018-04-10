using NUnit.Framework;

namespace LeetCodeProblems.P7
{
    [TestFixture]
    public class Tests7
    {
        [Test]
        public void Test1()
        {
            var solver = new Solution7();
            Assert.AreEqual(2147483641, solver.Reverse(1463847412));
            Assert.AreEqual(0, solver.Reverse(1534236469));
            Assert.AreEqual(0, solver.Reverse(-2147483648));
            Assert.AreEqual(321, solver.Reverse(123));
            Assert.AreEqual(-321, solver.Reverse(-123));
            Assert.AreEqual(21, solver.Reverse(120));
        }


//        [Test]
//        public void Play()
//        {
//            Console.WriteLine(int.MaxValue);
//            Console.WriteLine(int.MinValue);
//
//        }
    }
}
