namespace Algorithms.Medium;
public class AddTwoNumbers
{
    public ListNode Solution(ListNode l1, ListNode l2)
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