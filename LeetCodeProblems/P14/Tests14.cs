using NUnit.Framework;

namespace LeetCodeProblems.P14
{
    [TestFixture]
    public class Tests14
    {
        [Test]
        public void Test1()
        {
            var s = new Solution14();
            Assert.AreEqual("12", s.LongestCommonPrefix(new[]
            {
                "12"
            }));

            Assert.AreEqual("1", s.LongestCommonPrefix(new[]
            {
                "12",
                "13"
            }));

            Assert.AreEqual("", s.LongestCommonPrefix(new[]
            {
                "12",
                "23"
            }));

            Assert.AreEqual("test", s.LongestCommonPrefix(new[]
            {
                "testrfewrgwtg",
                "testrfewrgwtg2",
                "test;vgjregnerjng",
                "testdyhntynte"
            }));
        }
    }
}