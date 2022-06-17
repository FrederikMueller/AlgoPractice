namespace Algorithms.Easy;
public class TandemBicycle
{
    /*
    Fully understand the problem
        Return either the minimum or the maximum total speed of all tandem bikes. A bike is operated by a blue and a red rider. The faster rider determines the speed.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Sort both arrays depending on the fastest bool. If fastest, reverse the second array to pair riders for max speed. If not fastest, we want to pair them up based on ascending sort for both arrays.
        Then iterate through both arrays at the same time. Adding the higher number to a total.
        Return the total. The inverse sort on one of the arrays takes care of min speed case.
    Then implement the simplified conceptual solution step by step
        Initially used sort and then reverse, but then googled how to do it in one go.
    Optimization. Big O analysis. Amortization?
        Time = n log n
        Space = 1
    */
    public int GetSpeed(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
    {
        Array.Sort(redShirtSpeeds);
        if (fastest)
            Array.Sort(blueShirtSpeeds, (a, b) => b.CompareTo(a));
        else
            Array.Sort(blueShirtSpeeds);

        int totalSpeed = 0;
        for (int i = 0; i < redShirtSpeeds.Length; i++)
        {
            if (redShirtSpeeds[i] >= blueShirtSpeeds[i])
                totalSpeed += redShirtSpeeds[i];
            else
                totalSpeed += blueShirtSpeeds[i];
        }

        return totalSpeed;
    }
}