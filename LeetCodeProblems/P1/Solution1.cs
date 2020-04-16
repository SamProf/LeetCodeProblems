using System;
using System.Collections.Generic;

namespace LeetCodeProblems.P1
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var v = nums[i];
                int i1;
                if (dic.TryGetValue(target - v, out i1)) return new[] {i1, i};

                dic[v] = i;
            }

            return null;
        }
    }
}