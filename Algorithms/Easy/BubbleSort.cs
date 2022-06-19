namespace Algorithms.Easy;
public class BubbleSort
{
    /*
    Fully understand the problem
        Sort the input array of ints with bubble sort.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Compare current element with next, if it is larger, swap positions. If not, move to the next element and do the same. Once an element reaches the end of the array, limit the sort to the element before that.
    Then implement the simplified conceptual solution step by step
        Implemented the algorithm with a while loop and two index variables. Feels pretty simple to read, but probably there are cleener solutions.
    Optimization. Big O analysis. Amortization?
        Time =  N²
        Space = 1
    */
    public int[] Sort(int[] array)
    {
        int endIndex = array.Length - 1;
        int currentIndex = 0;

        while (endIndex > 0)
        {
            if (currentIndex == endIndex)
            {
                endIndex--;
                currentIndex = 0;
            }

            int current = array[currentIndex];
            int next = array[currentIndex + 1];

            if (current > next)
            {
                int temp = next;
                next = current;
                current = temp;
            }
            else
                currentIndex++;
        }

        return array;
    }
}