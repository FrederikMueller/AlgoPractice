namespace Algorithms.Easy;
public class SortedSquaredArray
{
    /*
    Fully understand the problem
        Input: non empty array of sorted ints. Output: square each entry and return in ascending order.
    Look for potential simplifications of the problem
        Negative integers can be in the input. Which means we cant just iterate through and change the values in place.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Store squares of neg nums on a stack. Compare current² vs top of stack. Build list.
    Then implement the simplified conceptual solution step by step
        Build the stack till you reach 0. Build result from 0 onwards by comparing positive numbers squared in input vs top of the stack
        Continue till result is filled. At the end empty the stack into the list. Return the list as array.
        Made a huge basic mistake by comparing top of stack with the unsquared value of the current item.
    Optimization. Big O analysis. Amortization?
        Time = N / N
        Space = N+n / N
    Video Notes:
        Brute Force solution: Square everything, then sort. N log N because of the sort.
        Clean solution: use 2 pointers on start and end of array. Compare abs value and build the output array from the end. Move pointers inward.
    */

    public int[] StackBasedSolution(int[] array)
    {
        Stack<int> stack = new Stack<int>();
        List<int> squaredInts = new List<int>();
        int idx = 0;

        while (idx < array.Length)
        {
            if (array[idx] < 0)
            {
                stack.Push(array[idx] * array[idx]);
                idx++;
            }
            else
            {
                if (stack.Count > 0 && stack.Peek() <= (array[idx] * array[idx]))
                {
                    squaredInts.Add(stack.Pop());
                }
                else
                {
                    squaredInts.Add(array[idx] * array[idx]);
                    idx++;
                }
            }
        }

        while (stack.Count > 0)
            squaredInts.Add(stack.Pop());

        return squaredInts.ToArray();
    }
    // Pointer-based solution
    public int[] PointerBasedSolution(int[] array)
    {
        int[] squaredInts = new int[array.Length];
        int startPointer = 0;
        int endPointer = array.Length - 1;
        int currentPos = array.Length - 1;

        while (startPointer <= endPointer)
        {
            if (Math.Abs(array[startPointer]) > array[endPointer])
            {
                squaredInts[currentPos] = array[startPointer] * array[startPointer];
                startPointer++;
                currentPos--;
            }
            else
            {
                squaredInts[currentPos] = array[endPointer] * array[endPointer];
                endPointer--;
                currentPos--;
            }
        }

        return squaredInts;
    }
}