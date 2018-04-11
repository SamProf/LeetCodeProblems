using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P16
{
    public class Solution16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            var res = int.MaxValue;

            for (int i1 = 0; i1 < nums.Length - 2; i1++)
            {
                var i2 = i1 + 1;
                var i3 = nums.Length - 1;

                while (i2 < i3)
                {
                    var cur = target - (nums[i1] + nums[i2] + nums[i3]);
                    if (Math.Abs(cur) < Math.Abs(res))
                    {
                        res = cur;
                    }

                    if (cur > 0)
                    {
                        i2++;
                    }
                    else if (cur < 0)
                    {
                        i3--;
                    }
                    else
                    {
                        i2++;
                        i3--;
                    }
                }
            }

            return   target - res;
        }
    }
}