namespace LeetCodeProblems.P14
{
    public class Solution14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var pref = "";
            if (strs.Length == 0) return pref;

            var str0 = strs[0];
            for (var index = 0; index < str0.Length; index++)
            {
                var ch = str0[index];
                for (var i = 1; i < strs.Length; i++)
                    if (index >= strs[i].Length || ch != strs[i][index])
                        return pref;

                pref += ch;
            }

            return pref;
        }
    }
}