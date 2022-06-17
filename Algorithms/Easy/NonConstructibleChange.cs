namespace Algorithms.Easy;
public class NonConstructibleChange
{
    /*
    Fully understand the problem
        Find the minimum amount of change I cant create with the coins I have.
    Input: unsorted, positive int array, can have duplicates.
        Output: Min amount I cant create with those coins.
    Look for potential simplifications of the problem
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        One path : Sort the array. Go through all positive integers one by one. Check all coins that are equal or smaller to see whether we can get to that int. Use a Return the first int we cant build.
    Then implement the simplified conceptual solution step by step
        Tried a scuffed recursive solution. This didn’t work. The solution is just based on a simple math insight / formula.
    Optimization. Big O analysis. Amortization?
        Time = n log n
        Space = 1
    Video Notes:
        Definitely visualize the problem if you're stuck or the solution feels overly complicated.
        The guarantee that you can create any number below the one you're currently adding is something I missed.
        You would never reach the current number if any number lower than that wasn’t creatable. And any number below the current one has been checked and can be created without the current one,
        so you can create everything you could before plus this current number. Going through the coins you have instead of what you're looking for is a bit counteintuitive, but it makes sense.
    */
    public int FindLowestNonconstructibleChange(int[] coins)
    {
        Array.Sort(coins);
        int maxChangePossible = 0;

        foreach (int coin in coins)
        {
            if (coin <= maxChangePossible + 1)
                maxChangePossible += coin;
            else
                return maxChangePossible + 1;
        }

        return maxChangePossible + 1;
    }
}