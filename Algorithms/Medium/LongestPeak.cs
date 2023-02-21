namespace Algorithms.Medium;
public static class LongestPeak
{
    /*
    	Problem Solving: Very uninspired brute forcing method. No cancellation of steps found. I just went through all possible states and coded it out. It works, but looks messy and doesn’t feel right.
	    Issues: Some edge cases didn’t work at first. I had to check the tests individually and fix my code iteratively. Seems like I missed some huge trick.
	    Video Notes:
		Two step process: 1) Find Peaks 2) Compare sizes
		Find peaks by comparing a number to its neighbors. Iterate through the array that way, find all peaks. 2 in the case of the default input.
		How far out to the left and how far to the right can we traverse? Super simple this way.
		I used a helper method to quickly calculate the neighbor count. Also, you can do both steps in one go, you don’t need to create a list to store them.
		Time = O(N)
        Space = O(1)
    */
    public static int GetLongestPeak(int[] array)
    {
        int result = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i - 1] < array[i] && array[i + 1] < array[i])
            {
                int sum = 1 + CountPeakSize(i, array);
                if (sum > result)
                    result = sum;
            }
        }
        return result;
    }
    static int CountPeakSize(int index, int[] array)
    {
        int count = 0;
        int peakPos = index;
        // TO THE LEFT
        while (index - 1 >= 0 && array[index] > array[index - 1])
        {
            count++;
            index--;
        }
        // TO THE RIGHT
        index = peakPos;
        while (index < array.Length - 1 && array[index] > array[index + 1])
        {
            count++;
            index++;
        }

        return count;
    }
}