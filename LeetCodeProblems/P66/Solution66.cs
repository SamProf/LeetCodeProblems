namespace LeetCodeProblems.P66
{
    public class Solution66
    {
        public int[] PlusOne(int[] digits)
        {
            var i = digits.Length - 1;
            while (i >= 0 && digits[i] == 9)
            {
                digits[i] = 0;
                i--;
            }

            if (i >= 0)
            {
                digits[i]++;
            }
            else
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
            }

            return digits;
        }
    }
}