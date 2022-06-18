namespace Algorithms.Easy;
public class TwoNumberSum
{
    /*
    Fully understand the problem
        Non empty array of distinct integers and an int representig a target sum. If any two numbers sum up to the target sum, return them in an array in any order.
        Must add two different ints. At most one pair summing up to the target sum.
    Look for potential simplifications of the problem
        We can return immediately once we find a pair.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Iterate through the array, add current num to hashset, check hashset whether it contains the num that would sum up to the target with the current num
    Then implement the simplified conceptual solution step by step
        Used a hashset, super simple solution and just 1 iteration.
    Optimization. Big O analysis. Amortization?
        Time = n
        Space = n
    Video Notes:
        Douple for loop is the naive solution (n²). Sort and use two pointers is a n log n solution. Hashset is fastest, but requires more space.
    */
    public int[] HashSetSolution(int[] array, int targetSum)
    {
        HashSet<int> ints = new HashSet<int>();

        foreach (int num in array)
        {
            int diff = targetSum - num;
            if (ints.Contains(diff))
                return new int[] { num, diff };
            else
                ints.Add(num);
        }

        return new int[0];
    }
}