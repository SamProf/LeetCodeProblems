namespace LeetCodeProblems.P26
{
    public class Solution26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var index = 0;
            for (var i = 1; i < nums.Length; i++)
                if (nums[index] != nums[i])
                {
                    index++;

                    nums[index] = nums[i];
                }

            return index + 1;
        }
    }
}