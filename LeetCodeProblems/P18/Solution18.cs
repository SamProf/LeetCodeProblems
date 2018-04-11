using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P18
{
    public class Solution18
    {
        public void QuickSort(int[] nums, int i1, int i2)
        {
            if (i1 == i2)
            {
                return;
            }

            var l = i1;
            var r = i2;
            var v = nums[l + (r - l) / 2];

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

            QuickSort(nums, i1, l - 1);
            QuickSort(nums, l, i2);
        }


        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var list = new List<IList<int>>();

            if (nums.Length > 0)
            {
                QuickSort(nums, 0, nums.Length - 1);

//                Array.Sort(nums);

                for (int i1 = 0; i1 < nums.Length - 3; i1++)
                {
                    if (i1 > 0 && nums[i1 - 1] == nums[i1]) continue;

                    for (int i2 = i1 + 1; i2 < nums.Length - 2; i2++)
                    {
                        if (i2 > i1 + 1 && nums[i2 - 1] == nums[i2]) continue;

                        var i3 = i2 + 1;
                        var i4 = nums.Length - 1;

                        while (i3 < i4)
                        {
                            if (i3 > i2 + 1 && nums[i3] == nums[i3 - 1])
                            {
                                i3++;
                                continue;
                            }

                            if (i4 < nums.Length - 1 && nums[i4] == nums[i4 + 1])
                            {
                                i4--;
                                continue;
                            }


                            var t = nums[i1] + nums[i3] + nums[i4] + nums[i2];

                            if (t == target)
                            {
                                list.Add(new[] {nums[i1], nums[i2], nums[i3], nums[i4]});
                                i3++;
                                i4--;
                            }
                            else if (t > target)
                            {
                                i4--;
                            }
                            else
                            {
                                i3++;
                            }
                        }
                    }
                }
            }

            return list;
        }
    }
}