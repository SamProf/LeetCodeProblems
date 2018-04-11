using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.P12
{
    public class Solution12
    {
        public string IntToRoman(int num)
        {
            var digits = new[] {"M", "C", "X", "I"};
            var digits5 = new[] {null, "D", "L", "V"};
            var s = new StringBuilder();
            var digitIndex = 0;
            var digit = 1000;
            while (num != 0)
            {
                var d = num / digit;
                switch (d)
                {
                    case 0:
                        break;
                    case 1:
                        s.Append(digits[digitIndex]);
                        break;
                    case 2:
                        s.Append(digits[digitIndex]).Append(digits[digitIndex]);
                        break;
                    case 3:
                        s.Append(digits[digitIndex]).Append(digits[digitIndex]).Append(digits[digitIndex]);
                        break;
                    case 4:
                        s.Append(digits[digitIndex]).Append(digits5[digitIndex]);
                        break;
                    case 5:
                        s.Append(digits5[digitIndex]);
                        break;
                    case 6:
                        s.Append(digits5[digitIndex]).Append(digits[digitIndex]);
                        break;
                    case 7:
                        s.Append(digits5[digitIndex]).Append(digits[digitIndex]).Append(digits[digitIndex]);
                        break;
                    case 8:
                        s.Append(digits5[digitIndex]).Append(digits[digitIndex]).Append(digits[digitIndex])
                            .Append(digits[digitIndex]);
                        break;
                    case 9:
                        s.Append(digits[digitIndex]).Append(digits[digitIndex - 1]);
                        break;
                }

                num = num % digit;
                digit = digit / 10;
                digitIndex++;
            }

            return s.ToString();
        }
    }
}