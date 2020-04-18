using System;

namespace LeetCodeProblems.P992
{
    public class SolutionP992
    {
        public int SubarraysWithKDistinct(int[] A, int K)
        {
            int result = 0;
            var numbers = new int[A.Length + 1];
            var i1 = 0;
            var i2 = 0;
            var dif = 0;
            while (i1 < A.Length)
            {
                if (numbers[A[i2]] == 0)
                {
                    dif++;
                }

                numbers[A[i2]]++;
                i2++;
                if (dif == K)
                {
                    result++;
                }

                if (dif > K || i2 >= A.Length)
                {
                    Array.Clear(numbers, 0, numbers.Length);
                    i1++;
                    i2 = i1;
                    dif = 0;
                }
            }

            return result;
        }
    }
}