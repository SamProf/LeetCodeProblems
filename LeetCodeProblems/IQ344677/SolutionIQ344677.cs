using System;
using System.Collections.Generic;

namespace LeetCodeProblems.IQ344677
{
    public class SolutionIQ344677
    {
        private bool GetMin(List<int> ropes, List<int> ropes2, ref int i, ref int i2, out int value)
        {
            if (i < ropes.Count)
            {
                if (i2 < ropes2.Count)
                {
                    if (ropes[i] < ropes2[i2])
                    {
                        value = ropes[i];
                        i++;
                        return true;
                    }
                    else
                    {
                        value = ropes2[i2];
                        i2++;
                        return true;
                    }
                }
                else
                {
                    value = ropes[i];
                    i++;
                    return true;
                }
            }
            else
            {
                if (i2 < ropes2.Count)
                {
                    value = ropes2[i2];
                    i2++;
                    return true;
                }
                else
                {
                    value = default(int);
                    return false;
                }
            }
        }

        public int MinCost(List<int> ropes)
        {
            ropes.Sort();
            var ropes2 = new List<int>();
            var i = 0;
            var i2 = 0;
            var result = 0;
            while (true)
            {
                int v1;
                int v2;
                if (!GetMin(ropes, ropes2, ref i, ref i2, out v1))
                {
                    break;
                }

                if (!GetMin(ropes, ropes2, ref i, ref i2, out v2))
                {
                    break;
                }


                var v3 = v1 + v2;
                result += v3;
                if (i < ropes.Count && v3 <= ropes[i])
                {
                    i--;
                    ropes[i] = v3;
                }
                else
                {
                    ropes2.Add(v3);
                }
            }

            return result;
        }
    }
}