using System.Text;

namespace LeetCodeProblems.P6
{
    public class Solution6
    {
        public string Convert(string s, int numRows)
        {
            var sb = new StringBuilder(s.Length);
            for (var iRow = 0; iRow < numRows; iRow++)
            {
                var index = iRow;
                while (index < s.Length)
                {
                    sb.Append(s[index]);

                    if (numRows > 2 && iRow != 0 && iRow != numRows - 1)
                    {
                        var index2 = index + (numRows - 1 - iRow) * 2;
                        if (index2 < s.Length) sb.Append(s[index2]);
                    }

                    index += numRows;
                    if (numRows > 2) index += numRows - 2;
                }
            }

            return sb.ToString();
        }

        public string Convert2(string s, int numRows)
        {
            var rows = new StringBuilder[numRows];
            for (var iRow = 0; iRow < rows.Length; iRow++) rows[iRow] = new StringBuilder();

            var i = 0;
            while (i < s.Length)
            {
                for (var iRow = 0; iRow < numRows && i < s.Length; iRow++)
                {
                    rows[iRow].Append(s[i]);
                    i++;
                }

                for (var iRow = numRows - 2; iRow > 0 && i < s.Length; iRow--)
                {
                    rows[iRow].Append(s[i]);
                    i++;
                }
            }

            for (var j = 1; j < numRows; j++) rows[0].Append(rows[j]);

            return rows[0].ToString();
        }
    }
}