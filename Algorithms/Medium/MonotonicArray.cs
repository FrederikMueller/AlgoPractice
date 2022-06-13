namespace Algorithms.Medium;
public class MonotonicArray
{
    /*
    	Problem Solving:  Check for whether sequence is increasing or not. Move two pointers over the array and check each time if the initial condition is still met. Simple, but feels scuffed.
	    Issues: First I used a sum to check for whether the condition is still true, but that was obviously wrong. I then struggled with some edge cases.
                0, 1 numbers in the array as well as the same number repeated in the array. Kind of scuffed solution, my way of checking whether the sequence is increasing or decreasing seems scuffed.
	    Video Notes: Another way to solve this is to simply check for both directions simultaneously and disregard the direction check. If one of those two booleans remains true, then you have a monotonic array.
		Lesson: Sometimes you can circumvent a step if it doesn’t affect the result and you can get the required info in other ways.
		Time = O(N)
        Space = O(1)
    */
    public bool IsMonotonic(int[] array)
    {
        bool isNonDec = true;
        bool isNonInc = true;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
                isNonDec = false;
            if (array[i] > array[i - 1])
                isNonInc = false;
        }

        if (isNonInc || isNonDec)
            return true;
        else
            return false;
    }
}