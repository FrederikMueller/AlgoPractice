namespace Algorithms.Easy;
public class ProductSum
{
    /*
    Fully understand the problem
        Product sum = sum of the arrays elements * depth. Find the product sum for the input, which is a special array that  can have nested arrays. Return total for the array.
    Look for potential simplifications of the problem
        Treat each level of depth the same by using a helper method.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Traverse the array and add each element to a total. If we hit a nested array we call the sum method and pass in the depth.
        The first call of this helper method uses depth 1. Each total is added in recursively.
    Then implement the simplified conceptual solution step by step
        Made a basic mistake initially by forgetting to add the result of the nested call to the total.
    Optimization. Big O analysis. Amortization?
        Time = n
        Space = D (Depth of the special array, call stack)
    */
    public int RecursiveSolution(List<object> array) => SumThisLevel(array, 1);
    int SumThisLevel(List<Object> array, int depth)
    {
        int total = 0;

        foreach (var item in array)
        {
            if (item is int i)
            {
                total += i;
            }
            else
            {
                var list = item as List<object>;
                SumThisLevel(list, depth + 1);
            }
        }
        return total * depth;
    }
}