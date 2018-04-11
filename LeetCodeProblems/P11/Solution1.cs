using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P11
{
    public class Solution1
    {
        public int MaxArea(int[] height)
        {
            var max = 0;
            var l = 0;
            var r = height.Length - 1;
            while (l < r)
            {
                max = Math.Max(max, (r - l) * Math.Min(height[l], height[r]));
                if (height[l] <= height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return max;
        }
    }
}