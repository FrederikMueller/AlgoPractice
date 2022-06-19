namespace Algorithms.Easy;
public class BinarySearch
{
    /*
    Fully understand the problem
        Input: Sorted array of ints as well as target int. Use binary search to find the target int's index, if it isnt contained in the array, return -1.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Go to the mid point of the array. Compare the value to the target value. Then repeat this step based on whether the target is larger or smaller. Always halving the remaining array.
    Then implement the simplified conceptual solution step by step
        The structure of the algorithm looks a bit weird, but it is correct. After changing the while loop to exit after the crossing of the pointers it looks fine.
    Optimization. Big O analysis. Amortization?
        Time = log n
        Space = 1
    */
    public int Search(int[] array, int target)
    {
        int lowerBound = 0;
        int upperBound = array.Length - 1;

        while (lowerBound <= upperBound)
        {
            int midPoint = (lowerBound + upperBound) / 2;
            if (array[midPoint] == target)
                return midPoint;

            if (array[midPoint] < target)
                lowerBound = midPoint + 1;
            if (array[midPoint] > target)
                upperBound = midPoint - 1;
        }
        return -1;
    }
}