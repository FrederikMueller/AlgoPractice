namespace Algorithms.Easy;
public class FirstNonRepeatingCharacter
{
    /*
    Fully understand the problem
        Return the index of the first non-repeating char. Non-repeating means occurs only once in the entire string.
    Look for potential simplifications of the problem
        We have to go to the end of the string, so no early exits
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Nested for loops fiesta OR Iterate through the string, store chars in a dictionary, check for contains each time
        Store count or index in there?
        At the end how do we get to the index easily?
    Then implement the simplified conceptual solution step by step
        Got the index either from another iteration through the string or using a dictionary of unique chars + hashset
    Optimization. Big O analysis. Amortization?
        Time = N
        Space = 1 since its capped at 26 (lower case chars in the english alphabet)
    */

    // Simple solution
    public int IterateTwice(string str)
    {
        Dictionary<char, int> candidates = new Dictionary<char, int>();

        for (int i = 0; i < str.Length; i++)
        {
            var character = str[i];
            candidates[character] = candidates.GetValueOrDefault(character, 0) + 1;
        }

        for (int i = 0; i < str.Length; i++)
        {
            var character = str[i];
            if (candidates[character] == 1)
                return i;
        }

        return -1;
    }
    // Looks way worse, but might be faster for huge inputs?
    public int WithHashSet(string str)
    {
        Dictionary<char, int> candidates = new Dictionary<char, int>();
        HashSet<char> addedChars = new HashSet<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (addedChars.Contains(str[i]))
                candidates.Remove(str[i]);
            else
            {
                addedChars.Add(str[i]);
                candidates.Add(str[i], i);
            }
        }

        if (candidates.Count == 0)
            return -1;
        else
        {
            int lowestIdx = Int32.MaxValue;
            foreach (var charEntry in candidates)
            {
                if (charEntry.Value < lowestIdx)
                    lowestIdx = charEntry.Value;
            }
            return lowestIdx;
        }
    }
}