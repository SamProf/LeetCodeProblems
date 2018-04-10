namespace LeetCodeProblems.P27
{
    public class Solution27
    {
        public int RemoveElement(int[] nums, int val)
        {
            var index = -1;
            for (var i = 0; i < nums.Length; i++)
                if (nums[i] != val)
                {
                    index++;
                    nums[index] = nums[i];
                }

            return index + 1;
        }
    }
}