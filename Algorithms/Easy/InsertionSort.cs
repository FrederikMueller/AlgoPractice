namespace Algorithms.Easy;
public class InsertionSort
{
    /*
    Fully understand the problem
        Input: array of ints. Output: Sorted version of the array via Insertion Sort.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Start with element 1. Compare it to element 0. Sort them by swapping. Move to next element and sort it into the elements before it by traversing through them. That way the sorted part of the array grows as you insert each element.
    Then implement the simplified conceptual solution step by step
        Decided to split out the core functions i.e. Swaping and Traversing backwards.
    Optimization. Big O analysis. Amortization?
        Time = n²
        Space = 1
     */
    public int[] Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            TraverseBackwards(array, i);
        }

        return array;
    }

    void TraverseBackwards(int[] array, int start)
    {
        int idx = start;
        while (idx > 0 && array[idx] < array[idx - 1])
        {
            Swap(ref array[idx], ref array[idx]);
            idx--;
        }
    }

    void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}