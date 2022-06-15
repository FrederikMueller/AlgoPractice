namespace Algorithms.Easy;
public class GenerateDocument
{
    /*
    Fully understand the problem
	    Input: string, frequency of char in input must be >= whats required for the document
	    Output: just true or false, not the document itself

    Look for potential simplifications of the problem
	    Check whether enough of each characters are available in the input string. If characters < document, you know it's false.

    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Iterate through the characters string and populate a dict with the count of each char
        Iterate through the document string and check the dict, then decrement the value

    Then implement the simplified conceptual solution step by step
	    Simply building the dict for the input and then checking each char in the document string against that was easiest.

    Optimization. Big O analysis. Amortization?
        Time = n+m
        Space = c
    */

    public bool GenerateDoc(string characters, string document)
    {
        if (characters.Length < document.Length)
            return false;

        Dictionary<char, int> availableChars = new Dictionary<char, int>();

        // a bit easier to read compared to a for loop
        foreach (char c in characters)
        {
            availableChars[c] = availableChars.GetValueOrDefault(c, 0) + 1;
        }

        foreach (char c in document)
        {
            if (!availableChars.ContainsKey(c) || availableChars[c] == 0)
                return false;
            else
                availableChars[c]--;
        }

        return true;
    }
}
}