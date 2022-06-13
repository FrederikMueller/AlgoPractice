using System.Text;

namespace Algorithms.Easy;
public class RunLengthEncoding
{
    /*
        	Problem Solving: Traverse once, compare current char with last, update run length, on end of run, store encoded value in the correct format (checking >9)
	        Issues: Missed the obvious first char skip and the i-1 comparison initially. Makes everything much cleaner than with a helper variable.
	        Video Notes:  You can also just trigger an encode when a run exceeds 9 instead of looping all of them at once.
	        Time = O(N)
	        Space = O(N)
    */
    public string EncodeString(string str)
    {
        var sb = new StringBuilder();
        int currentRunLength = 1;

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == str[i - 1])
            {
                currentRunLength++;
            }
            else
            {
                EncodeRun(sb, str[i - 1], currentRunLength);
                currentRunLength = 1;
            }
        }
        EncodeRun(sb, str[^1], currentRunLength);

        return sb.ToString();
    }

    private static void EncodeRun(StringBuilder sb, char currentChar, int currentRunLength)
    {
        int modulos = currentRunLength / 9;
        int rest = currentRunLength % 9;

        for (int j = 0; j < modulos; j++)
            sb.Append('9').Append(currentChar);

        if (rest > 0)
            sb.Append(rest).Append(currentChar);
    }
}