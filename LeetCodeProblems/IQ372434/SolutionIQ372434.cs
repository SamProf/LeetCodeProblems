using System;
using System.Collections.Generic;

namespace LeetCodeProblems.IQ372434
{
    public class SolutionIQ372434
    {
        public int Solve(int[] nums, int target)
        {
            var set = new HashSet<int>();
            var resultSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(target - nums[i]))
                {
                    resultSet.Add(Math.Min(nums[i], target - nums[i]));
                }

                set.Add(nums[i]);
            }

            return resultSet.Count;
        }
    }
}