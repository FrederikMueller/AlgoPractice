namespace Algorithms.Easy;
public class ClassPhotos
{
    /*
    Fully understand the problem
        Same color per row. Back row element must be greater than the front row element of the same idx.
        Return whether the constraint can be fulfilled.
    Look for potential simplifications of the problem
        The smallest and the largest student limit the solution. Also any equal height after sorting returns false.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        4,  5 , 7 , 8
        4, 6, 8, 10
        Return false if the  smallest students are equal, same for tallest, Then set back and front based on who is smaller.
        Seems super straight forward once you have the back and front row. Each item must adhere to the rule.
    Then implement the simplified conceptual solution step by step
        EZ
    Optimization. Big O analysis. Amortization?
        Time = n log n
        Space = 1
    */
    public bool CanTakeClassPhoto(List<int> redShirtHeights, List<int> blueShirtHeights)
    {
        redShirtHeights.Sort();
        blueShirtHeights.Sort();

        if (blueShirtHeights[0] > redShirtHeights[0])
        {
            return CompareHeights(blueShirtHeights, redShirtHeights);
        }
        else if (redShirtHeights[0] > blueShirtHeights[0])
        {
            return CompareHeights(redShirtHeights, blueShirtHeights);
        }

        return false;
    }

    public bool CompareHeights(List<int> tallGroup, List<int> shortGroup)
    {
        for (int i = 0; i < tallGroup.Count; i++)
        {
            if (tallGroup[i] <= shortGroup[i])
                return false;
        }
        return true;
    }
}