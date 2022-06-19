namespace Algorithms.Easy;
public class FindThreeLargestNumbers
{
    /*
    Fully understand the problem
        Find the 3 largest ints in the input array without sorting it. Return them in an ordered array. 3 ints in input are guaranteed.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Create the result array. Iterate through the input array and compare each element to your result array. Insert based on value. Return result array.
    Then implement the simplified conceptual solution step by step
        Clean solution with a helper method.
    Optimization. Big O analysis. Amortization?
        Time = n
        Space = 1
    Video Notes:
        Ez cleaner than video solution.
    */
    int[] result = new int[] { int.MinValue, int.MinValue, int.MinValue };
    public int[] GetThreeLargestNumbers(int[] array)
    {
        foreach (var num in array)
        {
            CompareAndInsert(2, num);
        }

        return result;
    }

    void CompareAndInsert(int idx, int x)
    {
        if (idx < 0)
            return;

        if (x > result[idx])
        {
            int oldNum = result[idx];
            result[idx] = x;
            CompareAndInsert(idx - 1, oldNum);
        }
        else
        {
            CompareAndInsert(idx - 1, x);
        }
    }
}