using System.Text;

namespace Algo_Practice;

public class Medium
{
    #region AddTwoNumbers

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // 0+
        // 3 4 5
        // 8 4 2 3 4
        // 1 9 7 2 4
        // 1. iterate through both LL at the same time
        // 2. add the numbers, add the resulting last digit in a new LL. store the overhang
        // 3. keep going until both LLs are exhausted

        var output = new ListNode();
        var start = output;

        int extra = 0;

        while (true)
        {
            int sum = l1.val + l2.val + extra;
            extra = 0;

            if (sum > 9)
            {
                sum -= 10;
                extra = 1;
            }
            output.val = sum;

            if (l1.next is null && l2.next is null && extra == 0)
                return start;

            if (l1.next != null)
                l1 = l1.next;
            else
                l1.val = 0;

            if (l2.next != null)
                l2 = l2.next;
            else
                l2.val = 0;

            output.next = new ListNode();
            output = output.next;
        }

        // First try
        // definitely do the clean conceptual walkthrough first
        // ideally create a rough guideline for that
    }

    #endregion AddTwoNumbers

    #region ZigZag Conversion

    // Cringe how long it took me. Need to get back into that mindset hard.
    // most solutions look kinda nasty
    // get gap, means get dir and check for overflow
    // obvious to combine the row restarts
    // "inverting" direction was a good clue
    // practice practice practice
    public string Convert(string s, int numRows)
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

    #endregion ZigZag Conversion
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}