namespace Algorithms.Easy;
public class SelectionSort
{
    /*
    Fully understand the problem
        Input: array of ints. Output: sorted array of ints via selection sort algorithm.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Sort the array by moving the smallest int you can find to the end of the sorted sub list by swapping the first element of the unsorted part with the element you just found is the smallest. The sorted sub list grows as you move through the unsorted part of the array.
    Then implement the simplified conceptual solution step by step
        Felt most clean using a while loop for the outer loop and a for loop for the inner loop.
    Optimization. Big O analysis. Amortization?
        Time = N²
        Space = 1
    */
    public int[] Sort(int[] array)
    {
        int startIdx = 0;
        int lowestIdx = 0;

        while (startIdx < array.Length - 1)
        {
            for (int i = startIdx; i < array.Length; i++)
            {
                if (array[i] < array[lowestIdx])
                    lowestIdx = i;
            }

            if (lowestIdx != startIdx)
            {
                int temp = array[startIdx];
                array[startIdx] = array[lowestIdx];
                array[lowestIdx] = temp;
            }

            startIdx++;
            lowestIdx = startIdx;
        }

        return array;
    }
}