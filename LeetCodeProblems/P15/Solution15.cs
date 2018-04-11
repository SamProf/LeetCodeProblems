using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P15
{
    public class Solution15
    {
        public void Sort(int[] nums, int l1, int r1)
        {
            if (r1 == l1)
            {
                return;
            }

            var l = l1;
            var r = r1;

            var mid = l + (r - l) / 2;
            var v = nums[mid];
            while (l <= r)
            {
                while (nums[l] < v)
                {
                    l++;
                }

                while (nums[r] > v)
                {
                    r--;
                }

                if (l <= r)
                {
                    var t = nums[l];
                    nums[l] = nums[r];
                    nums[r] = t;
                    l++;
                    r--;
                }
            }

            Sort(nums, l1, l - 1);
            Sort(nums, l, r1);
        }


        public IList<IList<int>> ThreeSum(int[] nums)
        {
            
            var list = new List<IList<int>>();
            if (nums.Length > 0)
            {
                this.Sort(nums, 0, nums.Length - 1);
                for (var i = 0; i < nums.Length - 2; i++)
                {
                    if (i > 0 && nums[i] == nums[i - 1]) continue;

                    var j = i + 1;
                    var k = nums.Length - 1;

                    while (j < k)
                    {
                        if (j > i + 1 && nums[j] == nums[j - 1])
                        {
                            j++;
                            continue;
                        }

                        if (k < nums.Length - 1 && nums[k] == nums[k + 1])
                        {
                            k--;
                            continue;
                        }

                        var sum = nums[i] + nums[j] + nums[k];

                        if (sum == 0)
                        {
                            list.Add(new[] {nums[i], nums[j], nums[k]});
                            j++;
                            k--;
                        }
                        else if (sum > 0)
                        {
                            k--;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
            }

            return list;
        }
    }
}