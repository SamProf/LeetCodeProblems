namespace LeetCodeProblems.P58
{
    public class Solution58
    {
        public int LengthOfLastWord(string s)
        {
            if (s == null) return 0;

            var i = s.Length - 1;
            while (i >= 0 && s[i] == ' ') i--;

            var end = i;
            while (i >= 0 && s[i] != ' ') i--;

            return end - i;
        }
    }
}