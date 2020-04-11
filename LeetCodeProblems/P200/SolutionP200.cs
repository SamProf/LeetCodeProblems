using System;
using System.Collections.Generic;

namespace LeetCodeProblems.P200
{
    public class SolutionP200
    {
        public void Clear(char[][] grid, int i, int j)
        {
            if (j < 0 || i < 0 || i >= grid.Length)
            {
                return;
            }

            var line = grid[i];
            if (j >= line.Length)
            {
                return;
            }

            if (line[j] == '0')
            {
                return;
            }


            line[j] = '0';


            Clear(grid, i - 1, j);
            Clear(grid, i + 1, j);
            Clear(grid, i, j - 1);
            Clear(grid, i, j + 1);
        }

        public int NumIslands(char[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                var line = grid[i];
                for (var j = 0; j < line.Length; j++)
                {
                    if (line[j] == '1')
                    {
                        result++;
                        Clear(grid, i, j);
                    }
                }
            }

            return result;
        }
    }
}