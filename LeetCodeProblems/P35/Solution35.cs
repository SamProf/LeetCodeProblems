namespace LeetCodeProblems.P35
{
    public class Solution35
    {
        public int SearchInsert(int[] nums, int target)
        {
            var l = 0;
            var r = nums.Length - 1;
            while (l <= r)
            {
                var m = l + (r - l) / 2;
                if (target == nums[m]) return m;

                if (target > nums[m])
                    l = m + 1;
                else
                    r = m - 1;
            }

            return l;
        }
    }
}