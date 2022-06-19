namespace Algorithms.Easy;
public class PalindromeCheck
{
    /*
    Fully understand the problem
        Input: non-empty string Output: bool representing whethe the input is a palindrome or not.
    Look for potential simplifications of the problem
        Since a palindrome is a string that’s written the same forward and backward, we can use index pointers to compare chars.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Use two indexes to compare chars from start and end to the middle. Once they cross, end the comparison.
    Then implement the simplified conceptual solution step by step
        The crossover check always works since on uneven array lenghts both end up on the same element. On even array lengths they cross after the last comparison.
    Optimization. Big O analysis. Amortization?
        Time = n
        Space = 1
    */
    public bool IsPalindrome(string str)
    {
        int leftIdx = 0;
        int rightIdx = str.Length - 1;

        while (leftIdx <= rightIdx)
        {
            if (str[leftIdx] != str[rightIdx])
                return false;

            leftIdx++;
            rightIdx--;
        }

        return true;
    }
}