using System.Collections.Generic;

namespace LeetCodeProblems.IQ356960
{
    public class SolutionIQ356960
    {
        public int[] GivenSum(int[] nums, int target)
        {
            target -= 30;
            var dic = new Dictionary<int, int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (dic.TryGetValue(target - nums[i], out var i2))
                {
                    return new[] {i, i2};
                }

                dic[nums[i]] = i;
            }

            return null;
        }
    }
}