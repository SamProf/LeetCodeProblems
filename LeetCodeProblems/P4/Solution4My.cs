namespace LeetCodeProblems.P4
{
    public class Solution4My
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var length = nums1.Length + nums2.Length;
            var index = length / 2;
            var count = 1;
            if (length % 2 == 0)
            {
                index--;
                count++;
            }

            var sum = 0d;

            var i1 = 0;
            var i2 = 0;
            int v;
            while (true)
            {
                if (i1 < nums1.Length)
                {
                    if (i2 < nums2.Length)
                    {
                        if (nums1[i1] <= nums2[i2])
                        {
                            v = nums1[i1];
                            i1++;
                        }
                        else
                        {
                            v = nums2[i2];
                            i2++;
                        }
                    }
                    else
                    {
                        v = nums1[i1];
                        i1++;
                    }
                }
                else
                {
                    if (i2 < nums2.Length)
                    {
                        v = nums2[i2];
                        i2++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (i1 + i2 >= index + 1)
                {
                    sum += v;
                    if (i1 + i2 >= index + count)
                    {
                        break;
                    }
                }
            }

            return sum / count;
        }
    }
}