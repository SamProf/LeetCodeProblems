using System;

namespace LeetCodeProblems.P240
{
    public class SolutionP240
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);
            var im = 0;
            var @in = n - 1;
            while (im < m && @in >= 0)
            {
                var c = matrix[im, @in];
                if (c == target)
                {
                    return true;
                }

                if (target < c)
                {
                    @in--;
                }
                else
                {
                    im++;
                }
            }

            return false;
        }
    }
}