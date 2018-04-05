using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problem1
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var v = nums[i];
                int i1;
                if (dic.TryGetValue(target - v, out i1))
                {
                    return new[] {i1, i};
                }

                dic[v] = i;
            }

            throw new Exception("No result");
        }
    }
}