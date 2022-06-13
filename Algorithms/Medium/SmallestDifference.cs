namespace Algorithms.Medium;
public class SmallestDifference
{
    /*
     	Problem Solving: Core solution is clear, traversing both arrays simultaneously is neat though. Instead: while loop using 1 index for each array!
	    Issues: Mindfucked my break condition because I forgot how the absolute difference simplifies things. You can also use a single while loop and go through both arrays at the same time.
	    Video Notes:
		I should probably use the scratchpad more often and simply map out the conceptually solution that way.
		Double for loops is naïve.
		Use one pointer for each array and move across both arrays in the most efficient manner possible. Take the smaller value and move that pointer to the right.
		Time = O(N log (N) + M log (M))
        Space = O(1)
    */
    public int[] GetSmallestDifference(int[] arrayOne, int[] arrayTwo)
    {
        int ss = Int32.MaxValue;
        int[] result = new int[] { 0, 0 };

        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);

        int i1 = 0;
        int i2 = 0;

        while (i1 < arrayOne.Length && i2 < arrayTwo.Length)
        {
            int gap = arrayOne[i1] - arrayTwo[i2];
            if (Math.Abs(gap) < Math.Abs(ss))
            {
                ss = gap;
                result[0] = arrayOne[i1];
                result[1] = arrayTwo[i2];
            }

            if (gap < 0)
                i1++;
            else if (gap == 0)
                return result;
            else
                i2++;
        }
        return result;
    }
}