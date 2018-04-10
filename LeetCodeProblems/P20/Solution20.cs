using System.Collections.Generic;

namespace LeetCodeProblems.P20
{
    public class Solution20
    {
        public bool IsValid(string s)
        {
            var st = new Stack<char>();

            foreach (var ch in s)
                switch (ch)
                {
                    case '(':
                        st.Push(')');
                        break;
                    case '{':
                        st.Push('}');
                        break;
                    case '[':
                        st.Push(']');
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (st.Count == 0 || st.Pop() != ch) return false;

                        break;
                }

            return st.Count == 0;
        }
    }
}