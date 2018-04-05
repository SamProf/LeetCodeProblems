using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problem4
{
    public class Solution4My
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var a = new int[nums1.Length + nums2.Length];
            var i1 = 0;
            var i2 = 0;
            while (true)
            {
                if (i1 < nums1.Length)
                {
                    if (i2 < nums2.Length)
                    {
                        if (nums1[i1] <= nums2[i2])
                        {
                            a[i1 + i2] = nums1[i1];
                            i1++;
                        }
                        else
                        {
                            a[i1 + i2] = nums2[i2];
                            i2++;
                        }
                    }
                    else
                    {
                        a[i1 + i2] = nums1[i1];
                        i1++;
                    }
                }
                else
                {
                    if (i2 < nums2.Length)
                    {
                        a[i1 + i2] = nums2[i2];
                        i2++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            var index = a.Length / 2;
            if (a.Length % 2 == 0)
            {
                return (a[index] + a[index - 1]) / 2d;
            }
            else
            {
                return (a[index]);
            }
        }
    }
}