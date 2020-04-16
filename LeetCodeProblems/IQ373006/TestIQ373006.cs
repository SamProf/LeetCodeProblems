using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCodeProblems.IQ373006
{
    [TestFixture]
    public class TestIQ373006
    {
        [TestCaseSource(typeof(TestIQ373006), nameof(TestCases))]
        public void Test(Dictionary<string, List<string>> userSongs,
            Dictionary<string, List<string>> songGenres, Dictionary<string, List<string>> expected)
        {
            var s = new SolutionIQ373006();
            var r = s.Solve(userSongs, songGenres);
            Console.WriteLine(string.Join("\r\n", r.Select(u => $"{u.Key} : {string.Join(", ", u.Value)}")));
            Assert.AreEqual(expected, r);
        }


        static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new Dictionary<string, List<string>>()
                {
                    {"David", new List<string>() {"song1", "song2", "song3", "song4", "song8"}},
                    {"Emma", new List<string>() {"song5", "song6", "song7"}},
                },

                new Dictionary<string, List<string>>()
                {
                    {"Rock", new List<string>() {"song1", "song3"}},
                    {"Dubstep", new List<string>() {"song7"}},
                    {"Techno", new List<string>() {"song2", "song4"}},
                    {"Pop", new List<string>() {"song5", "song6"}},
                    {"Jazz", new List<string>() {"song8", "song9"}},
                },

                new Dictionary<string, List<string>>()
                {
                    {"David", new List<string>() {"Rock", "Techno"}},
                    {"Emma", new List<string>() {"Pop"}},
                },
            };


            yield return new object[]
            {
                new Dictionary<string, List<string>>()
                {
                    {"David", new List<string>() {"song1", "song2"}},
                    {"Emma", new List<string>() {"song3", "song4"}},
                },

                new Dictionary<string, List<string>>()
                {
                },

                new Dictionary<string, List<string>>()
                {
                    {"David", new List<string>() { }},
                    {"Emma", new List<string>() { }},
                },
            };
        }
    }
}