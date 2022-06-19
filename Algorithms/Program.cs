using Algorithms.Easy;
using Algorithms.Medium;

internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new int[] { 5, 2, 1, -22, 25, 3, -14 };

        var bs = new BubbleSort();

        var res = bs.Sort(arr);

        foreach (var num in res)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}