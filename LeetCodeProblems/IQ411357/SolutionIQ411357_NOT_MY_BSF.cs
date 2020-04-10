using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems.IQ411357
{
    public class SolutionIQ411357_NOT_MY_BSF : ISolutionIQ411357
    {
        public int MinHours(int rows, int columns, List<List<int>> grid)
        {
            if (rows == 0 || columns == 0) return 0;

            var q = new List<int[]>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        q.Add(new int[] { i, j });
                    }
                }
            }

            var directions = new List<int[]>{ new int[] { 1, 0 },  new int[] {-1, 0 }, new int[] { 0, 1 }, new int[] { 0,-1 }};
            var time = 0;
       
            while (true)
            {
                var newResult = new List<int[]>();
                foreach (var item in q)
                {
                    foreach (var d in directions)
                    {
                        var ni = item[0] + d[0];
                        var nj = item[1] + d[1];
                        if (0 <= ni && ni < rows && 0 <= nj && nj < columns && grid[ni][nj] == 0)
                        {
                            grid[ni][nj] = 1;
                            newResult.Add(new int[] { ni, nj });
                        }
                    }
                }
                q = newResult;
                if (q.Any() == false) break;
                time += 1;
            }
            return time;
        }
    }
}