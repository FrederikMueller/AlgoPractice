namespace Algorithms.Easy;
public class RemoveDuplicatesFromLinkedList
{
    /*
    Fully understand the problem
        Input: Head of sorted LL. Remove duplicates in place. Keep sort in tact. Return the head of the modified LL.
    Look for potential simplifications of the problem
        Cant find further simplifications.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        We cache head.
        We look at next value. If it is the same, we assign next.next to our.next. Then we repeat this.
        If next.value is not equal, we move to it.
    Then implement the simplified conceptual solution step by step
        Simple implementation with a while loop, initially used while(true), but while(next != null) is best
    Optimization. Big O analysis. Amortization?
        Time = N
        Space = 1
    Video Notes:
        No need to store the head, since the input isnt modified.
    */
    public LinkedList RemoveDuplicates(LinkedList linkedList)
    {
        var current = linkedList;

        while (current.next != null)
        {
            if (current.value == current.next.value)
                current.next = current.next.next;
            else
                current = current.next;
        }

        return linkedList;
    }
}

public class LinkedList
{
    public int value;
    public LinkedList next;

    public LinkedList(int value)
    {
        this.value = value;
        this.next = null;
    }
}