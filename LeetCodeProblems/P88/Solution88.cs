namespace LeetCodeProblems.P88
{
    public class Solution88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var index = m + n - 1;
            m--;
            n--;
            while (true)
                if (m >= 0)
                {
                    if (n >= 0)
                        if (nums1[m] >= nums2[n])
                            nums1[index--] = nums1[m--];
                        else
                            nums1[index--] = nums2[n--];
                    else
                        nums1[index--] = nums1[m--];
                }
                else
                {
                    if (n >= 0)
                        nums1[index--] = nums2[n--];
                    else
                        break;
                }
        }
    }
}