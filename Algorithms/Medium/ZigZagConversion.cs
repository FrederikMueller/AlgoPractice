using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Medium;
public class ZigZagConversion
{
    // Cringe how long it took me. Need to get back into that mindset hard.
    // most solutions look kinda nasty
    // get gap, means get dir and check for overflow
    // obvious to combine the row restarts
    // "inverting" direction was a good clue
    // practice practice practice
    public string Solution(string s, int numRows)
    {
        if (numRows == 1)
            return s;

        var sb = new StringBuilder();
        sb.Append(s[0]);

        bool downwards = true;
        int currentRow = 1;
        int currentIndex = 0;

        while (sb.Length < s.Length)
        {
            int gap;
            if (downwards)
                gap = (numRows - currentRow) * 2;
            else
                gap = (currentRow - 1) * 2;

            if (currentIndex + gap < s.Length)
            {
                currentIndex += gap;
                sb.Append(s[currentIndex]);

                if (currentRow == 1 || currentRow == numRows)
                    continue;
                else
                    downwards = !downwards;
            }
            else
            {
                currentRow++;
                currentIndex = currentRow - 1;
                sb.Append(s[currentIndex]);

                downwards = currentRow != numRows;
            }
        }
        return sb.ToString();
    }
}