
using System.Collections.Generic;


namespace LeetCodeProblems.IQ347457
{
    public class SolutionIQ347457
    {
        struct Point
        {
            public int I;
            public int J;
            public int C;

            public Point(int i, int j, int c)
            {
                I = i;
                J = j;
                C = c;
            }
        }


        static Point[] directions = new Point[]
        {
            new Point(-1, 0, 0),
            new Point(1, 0, 0),
            new Point(0, -1, 0),
            new Point(0, 1, 0),
        };

        public int TreasureIsland(char[][] map)
        {
            var q = new Queue<Point>();
            q.Enqueue(new Point(0, 0, 0));
            var il = map.Length;
            var jl = map[0].Length;

            while (q.Count > 0)
            {
                var p = q.Dequeue();
                foreach (var direction in directions)
                {
                    var i2 = p.I + direction.I;
                    if (i2 < 0 || i2 >= il)
                    {
                        continue;
                    }

                    var j2 = p.J + direction.J;
                    if (j2 < 0 || j2 >= jl)
                    {
                        continue;
                    }

                    var ch = map[i2][j2];

                    if (ch == 'X')
                    {
                        return p.C + 1;
                    }
                    else if (ch == 'O')
                    {
                        q.Enqueue(new Point(i2, j2, p.C + 1));
                        map[i2][j2] = 'V';
                    }
                }
            }

            return -1;
        }
    }
}