using Algorithms.Medium;

namespace Algorithms;

public static class Program
{
    private static void Main(string[] args)
    {
        var arr = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };

        foreach (var outputArray in ThreeNumberSum.PointerSolution(arr, 0))
        {
            foreach (var num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }

    // create helper extension methods to display outputs
    // make this proj something epic that you can use for a long while
    // create tests and samples in the file of the algo
    // review the ones you simply import, you at least have understand conceptually whats going on
}