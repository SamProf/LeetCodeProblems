using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P17
{
    public class Solution17
    {
        private string[] buttons = {"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

        public IList<string> LetterCombinations(string digits)
        {
            var list = new List<string>();

            if (digits.Length > 0)
            {
                Rec(list, digits, "");
            }

            return list;
        }


        private void Rec(List<string> list, string digits, string pre)
        {
            if (pre.Length < digits.Length)
            {
                foreach (var ch in buttons[digits[pre.Length] - '2'])
                {
                    Rec(list, digits, pre + ch);
                }
            }
            else
            {
                list.Add(pre);
            }
        }
    }
}