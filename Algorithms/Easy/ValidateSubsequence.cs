namespace Algorithms.Easy;
public class ValidateSubsequence
{
    /*
	    Issues: Slow to solve, but it was simple. Probably not a super lean solution.
	    Video Notes:
		The edge case I was thinking about the entire time is simply irrelevant. The answer is still true if you only check the first occurrence of a subset of the target sequence.
		BIG YIKES. Always simplify. This is hella easy if you grasp the problem truly. It doesn’t matter if you restart the sequence, that doesn’t change the overall evaluation!
		Time = O(N)
        Space = O(1)
    */

    public bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        for (int i = 0; i < array.Count; i++)
        {
            if (array[i] == sequence[0])
            {
                int arrPointer = i;
                int seqPointer = 0;
                while (arrPointer < array.Count)
                {
                    if (sequence[seqPointer] != array[arrPointer])
                    {
                        arrPointer++;
                    }
                    else
                    {
                        seqPointer++;
                        arrPointer++;
                    }
                    if (seqPointer == sequence.Count)
                        return true;
                }
            }
        }

        return false;
    }
}