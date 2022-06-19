using System.Text;

namespace Algorithms.Easy;
public class CaesarCypherEncryptor
{
    /*
    Fully understand the problem
        Input: non empty strings of lowercase letters and a non-negative int (key)
        Output: return a string with each letter of the input shifted by k positons in the alphabet. Wrap around.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Map each letter to an int. Iterate through the string and convert each char one by one by using the key + the map. Return the string at the end.
    Then implement the simplified conceptual solution step by step
        Used a dictionary to look up the values, you can also use letter codes.
    Optimization. Big O analysis. Amortization?
        Time = n
        Space = 1
    */
    public string Encrpyt(string str, int key)
    {
        var alphabet = "abcdefghijklmnopqrstuvwxyz";

        var letterToNumberDict = new Dictionary<char, int>();
        int count = 0;
        foreach (char letter in alphabet)
        {
            letterToNumberDict.Add(letter, count);
            count++;
        }

        var sb = new StringBuilder();
        foreach (char letter in str)
        {
            int letterIdx = letterToNumberDict[letter];
            int newIdx = (letterIdx + key) % 26;

            sb.Append(alphabet[newIdx]);
        }

        return sb.ToString();
    }
}