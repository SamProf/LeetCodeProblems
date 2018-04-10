namespace LeetCodeProblems.P53
{
    public class Solution53
    {
        public int MaxSubArray(int[] nums)
        {
            var max = int.MinValue;
            var cur = 0;
            foreach (var num in nums)
            {
                cur += num;
                if (cur > max) max = cur;

                if (cur < 0) cur = 0;
            }

            return max;
        }
    }
}