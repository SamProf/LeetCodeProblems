using System.Collections.Generic;

namespace LeetCodeProblems.IQ373202
{
    public class SolutionIQ373202
    {
        public List<int[]> GetPairs(List<int[]> a, List<int[]> b, int target)
        {
            var result = new List<int[]>();
            a.Sort(Comparer<int[]>.Create((v1, v2) => v1[1].CompareTo(v2[1])));
            b.Sort(Comparer<int[]>.Create((v1, v2) => v1[1].CompareTo(v2[1])));
            var ia = 0;
            var ib = b.Count - 1;
            
            var ial = -1; 
            var ibl = -1;
            var cl = int.MinValue;
            while (ia < a.Count && ib >= 0)
            {
                var c = a[ia][1] + b[ib][1];
                if (c > target)
                {
                    ib--;
                }
                else if (c < target)
                {
                    if (cl < c)
                    {
                        cl = c;
                        ial = ia;
                        ibl = ib;
                    }
                    ia++;
                    
                }
                else
                {
                    result.Add(new []{a[ia][0], b[ib][0]});
                    ib--;
                    ia++;
                }
            }


            if (result.Count == 0)
            {
                if (ial != -1)
                {
                    result.Add(new []{a[ial][0], b[ibl][0]});
                }
            }
            
            return result;
        }
    }
}