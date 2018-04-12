using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P22
{
    public class Solution22
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var list = new List<string>();
            Rec(list, n, "", 0, 0);
            return list;
        }


        public void Rec(List<string> list, int n, string cur, int c1, int c2)
        {
            if (c1 == n && c2 == n)
            {
                list.Add(cur);
                return;
            }

            if (c1 < n)
            {
                Rec(list, n, cur + '(', c1 + 1, c2);
            }

            if (c2 < c1)
            {
                Rec(list, n, cur + ')', c1, c2 + 1);
            }
        }
    }
}