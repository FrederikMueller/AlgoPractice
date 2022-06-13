namespace Algorithms.Medium;
public class SpiralTraverse
{
    /*
	    Issues: Difficult to start with, just had to dig into the logic of the turns. Basically hardcoded it with the direction method which isnt elegant, but it is easy to read.
	    Video Notes:
		Perimeter traversing simplifies the problem. My direction solution is more wordy, but it seems very intuitive and easy to understand.
		Time = O(N)
        Space = O(N)
    */
    public List<int> SpiralTraverse2DArray(int[,] array)
    {
        int rowMin = 0, rowMax = 0, colMin = 0, colMax = 0;
        int rc = 0, cc = 0;
        List<int> result = new List<int>();
        string dir = "right";

        rowMax = array.GetLength(0) - 1;
        colMax = array.GetLength(1) - 1;

        while (result.Count < array.Length)
        {
            result.Add(array[rc, cc]);

            if (dir == "right")
            {
                cc++;
                if (cc == colMax)
                {
                    dir = "down";
                    rowMin++;
                }
                continue;
            }
            if (dir == "down")
            {
                rc++;
                if (rc == rowMax)
                {
                    dir = "left";
                    colMax--;
                }

                continue;
            }
            if (dir == "left")
            {
                cc--;
                if (cc == colMin)
                {
                    dir = "up";
                    rowMax--;
                }

                continue;
            }
            if (dir == "up")
            {
                rc--;
                if (rc == rowMin)
                {
                    dir = "right";
                    colMin++;
                }
                continue;
            }
        }

        return result;
    }
}