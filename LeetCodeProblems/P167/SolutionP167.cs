namespace LeetCodeProblems.P167
{
    public class SolutionP167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var i1 = 0;
            var i2 = numbers.Length - 1;
            while (i1 < i2)
            {
                var t = numbers[i1] + numbers[i2];
                if (t == target)
                {
                    return new int[] {i1 + 1, i2 + 1};
                }

                if (t < target)
                {
                    i1++;
                }
                else
                {
                    i2--;
                }
            }

            return null;
        }
    }
}