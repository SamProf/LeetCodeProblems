using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Core
{
    public static class ArrayHelper
    {
        static Random rnd = new Random();

        public static int[] RandomArray(int n, int max)
        {
            return Enumerable.Range(0, n).Select(i => rnd.Next(0, max)).ToArray();
        }

        public static int[] RandomArraySorted(int n, int max)
        {
            return RandomArray(n, max).OrderBy(i => i).ToArray();
        }
    }
}