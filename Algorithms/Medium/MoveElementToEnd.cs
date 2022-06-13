namespace Algorithms.Medium;
public class MoveElementToEnd
{
    /*
    	Problem Solving: I used the pointer method to traverse through the array and swap those values that are equal to t he target value.
	    Issues: None.
	    Video Notes:
		Time = O(N)
        Space = O(1)
    */
    public List<int> MoveElement(List<int> array, int toMove)
    {
        int i = 0;
        int j = array.Count - 1;

        while (i < j)
        {
            if (array[j] == toMove)
            {
                j--;
                continue;
            }
            if (array[i] == toMove)
            {
                array[i] = array[j];
                array[j] = toMove;
                j--;
            }
            i++;
        }
        return array;
    }
}