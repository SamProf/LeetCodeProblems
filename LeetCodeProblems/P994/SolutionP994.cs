using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeProblems.P994
{
    public class SolutionP994
    {
        private static Point[] Movements = new[]
        {
            new Point(-1, 0, 0),
            new Point(1, 0, 0),
            new Point(0, -1, 0),
            new Point(0, 1, 0),
        };


        public int OrangesRotting(int[][] grid)
        {
            var q = new Queue<Point>();
            var c1Count = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                var l = grid[i];
                for (var j = 0; j < l.Length; j++)
                {
                    var c = l[j];
                    if (c == 2)
                    {
                        q.Enqueue(new Point(i, j, 0));
                    }
                    else if (c == 1)
                    {
                        c1Count++;
                    }
                }
            }


            var maxDepth = 0;
            while (q.Count > 0 && c1Count > 0)
            {
                var p = q.Dequeue();


                foreach (var movement in Movements)
                {
                    var i2 = p.I + movement.I;
                    var j2 = p.J + movement.J;
                    if (i2 < 0 || i2 >= grid.Length)
                    {
                        continue;
                    }

                    var l = grid[i2];
                    if (j2 < 0 || j2 >= l.Length)
                    {
                        continue;
                    }

                    var c = l[j2];
                    if (c == 1)
                    {
                        l[j2] = 2;
                        maxDepth = Math.Max(maxDepth, p.Depth + 1);
                        q.Enqueue(new Point(i2, j2, p.Depth + 1));
                        c1Count--;
                    }
                }
            }

            return c1Count > 0 ? -1 : maxDepth;
        }


        struct Point
        {
            public int I;
            public int J;
            public int Depth;

            public Point(int i, int j, int depth)
            {
                I = i;
                J = j;
                Depth = depth;
            }
        }
    }
}