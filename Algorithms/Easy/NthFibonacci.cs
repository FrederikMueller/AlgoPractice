namespace Algorithms.Easy;
public class NthFibonacci
{
    /*
    Fully understand the problem
        Return the nth fibonacci number based on the input n.
    Look for potential simplifications of the problem
        0, 1, 1 … First fibonacci number is 0 in this case, not 0 indexed.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Iterative: hard code return n=1, calc n>1 via loop. Recursive: 2 base cases + memoize results.
    Then implement the simplified conceptual solution step by step
        This time I used an iterative approach first, feels not as elegant as recursive though, but a bit more efficient than the memoized recursive solution.
    Optimization. Big O analysis. Amortization?
        Time = n | n
        Space = 1 | n
    */
    // Iterative solution with temp var
    public int GetNthFibIteratively(int n)
    {
        if (n == 1)
            return 0;

        int last = 0;
        int current = 1;
        int temp;

        for (int i = 2; i < n; i++)
        {
            temp = current;
            current = last + current;
            last = temp;
        }

        return current;
    }

    // Recursive solution with memoization and dict init for base cases
    Dictionary<int, int> fibs = new Dictionary<int, int> { { 1, 0 }, { 2, 1 } };
    public int GetNthFibRecursively(int n)
    {
        if (fibs.ContainsKey(n))
            return fibs[n];
        else
        {
            fibs.Add(n, GetNthFibRecursively(n - 1) + GetNthFibRecursively(n - 2));
            return fibs[n];
        }
    }
}