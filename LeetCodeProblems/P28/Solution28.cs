namespace LeetCodeProblems.P28
{
    public class Solution28
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0, length = haystack.Length - needle.Length + 1; i < length; i++)
            {
                var f = true;
                for (var j = 0; j < needle.Length; j++)
                    if (haystack[i + j] != needle[j])
                    {
                        f = false;
                        break;
                    }

                if (f) return i;
            }

            return -1;
        }
    }
}