namespace LeetCodeProblems.P59
{
    public class SolutionP59
    {
        public int[][] GenerateMatrix(int n)
        {
            var a = new int[n][];
            for (var i = 0; i < n; ++i)
            {
                a[i] = new int[n];
            }


            var startPos = 0;
            var counter = 0;
            while (n != 0)
            {
                var col = startPos;
                var row = startPos;
                a[row][col] = ++counter;

                if (n == 1)
                {
                    break;
                }

                var ndec = n - 1;
                for (int i = 0; i < ndec; ++i)
                {
                    col++;
                    a[row][col] = ++counter;
                }

                for (int i = 0; i < ndec; ++i)
                {
                    row++;
                    a[row][col] = ++counter;
                }


                for (int i = 0; i < ndec; ++i)
                {
                    col--;
                    a[row][col] = ++counter;
                }

                ndec--;
                for (int i = 0; i < ndec; ++i)
                {
                    row--;
                    a[row][col] = ++counter;
                }

                n -= 2;
                startPos++;
            }

            return a;
        }

        public int[][] GenerateMatrixOld(int n)
        {
            var a = new int[n][];
            var directions = new[]
            {
                new
                {
                    Row = 0,
                    Col = 1,
                },
                new
                {
                    Row = 1,
                    Col = 0,
                },
                new
                {
                    Row = 0,
                    Col = -1,
                },
                new
                {
                    Row = -1,
                    Col = 0,
                },
            };
            for (var i = 0; i < n; i++)
            {
                a[i] = new int[n];
            }


            var col = 0;
            var row = 0;
            var directionIndex = 0;
            for (int i = 0; i < n * n; i++)
            {
                a[row][col] = i + 1;

                col += directions[directionIndex].Col;
                row += directions[directionIndex].Row;
                if (col < 0 || row < 0 || col >= n || row >= n || a[row][col] != 0)
                {
                    col -= directions[directionIndex].Col;
                    row -= directions[directionIndex].Row;
                    directionIndex = (directionIndex + 1) % directions.Length;
                    col += directions[directionIndex].Col;
                    row += directions[directionIndex].Row;
                }
            }


            return a;
        }
    }
}