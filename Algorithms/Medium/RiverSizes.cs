namespace Algorithms.Medium;
public class RiverSizes
{
    /*
	    Issues: Weak minded, unfocused, simply not in the mode to tackle the problem, even though it is not difficult. Also I constantly thought there should be an easier, more elegant solution, but I don’t think there is. Lets watch the video.
	    Video Notes:
        Treat this problem as a  graph traversal problem. Recursive DFS/BFS algorithm.
    */

    public List<int> GetRiverSizes(int[,] matrix)
    {
        List<int> rivers = new List<int>();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int output = CalcRiverLength2(matrix, i, j);
                if (output > 0)
                {
                    rivers.Add(output);
                }
            }
        }
        return rivers;
    }
    public int CalcRiverLength2(int[,] matrix, int x, int y)
    {
        if (x < 0 || x > matrix.GetLength(0) - 1)
            return 0;
        if (y < 0 || y > matrix.GetLength(1) - 1)
            return 0;

        if (matrix[x, y] == 0)
            return 0;

        int currentRiverSize = 1;
        matrix[x, y] = 0;

        currentRiverSize += CalcRiverLength2(matrix, x, y - 1);
        currentRiverSize += CalcRiverLength2(matrix, x + 1, y);
        currentRiverSize += CalcRiverLength2(matrix, x, y + 1);
        currentRiverSize += CalcRiverLength2(matrix, x - 1, y);

        return currentRiverSize;
    }
}