namespace Algorithms.Medium;
public static class ThreeNumberSum
{
    /*
        Problem Solving: Straightforward. Everything worked out fine, I just think it isnt the optimal solution because of the duplicate work and the 2 loops it uses.
        Issues: No issues, worked first try, but I think I could've tried to go for a better solution. Lets find out what tricks I missed.
        Video Notes:
            Best technique to solve this problem. Sort the array. Left and right pointer.
            [-8, -6, 1, 2, 3, 5, 6, 12]
              =    ^                 ^
            Move the pointer that moves the sum towards the target.
            Move only left, only right or even both at the same time (when you hit the target and need to look further)
            Pointer passing = GG iteration
            Now start with -6 as the base value and iterate over the array with your pointers.
            The pointer movement logic is super powerful for tons of array manipulation problems.
            Time = O(N²)
            Space = O(N)
    */

    public static List<int[]> ThreeNumberSum2(int[] array, int targetSum)
    {
        Array.Sort(array);
        var sums = new List<int[]>();

        for (int i = 0; i < array.Length - 2; i++)
        {
            int left = i + 1;
            int right = array.Length - 1;

            while (left < right)
            {
                int sum = array[i] + array[left] + array[right];
                if (sum == targetSum)
                {
                    sums.Add(new int[] { array[i], array[left], array[right] });
                    left++;
                    right--;
                }

                if (sum < targetSum)
                {
                    left++;
                }

                if (sum > targetSum)
                {
                    right--;
                }
            }
        }

        return sums;
    }
    public static List<int[]> ThreeNumberSum1(int[] array, int targetSum)
    {
        Array.Sort(array);
        var listOfTriplets = new List<int[]>();
        var dict = new Dictionary<int, bool>();

        foreach (var item in array)
        {
            dict.Add(item, true);
        }

        for (int i = 0; i < array.Length; i++)
        {
            int firstNum = array[i];
            int newTarget = targetSum - firstNum;

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == firstNum)
                    continue;

                int lastTarget = newTarget - array[j];

                if (dict.ContainsKey(lastTarget) && lastTarget != firstNum && lastTarget != array[j])
                {
                    var triplet = new int[] { firstNum, array[j], lastTarget };
                    Array.Sort(triplet);

                    if (!CompareTriplets(triplet, listOfTriplets))
                        listOfTriplets.Add(triplet);
                }
            }
        }

        return listOfTriplets;
    }
    public static bool CompareTriplets(int[] triplet, List<int[]> listOfTriplets)
    {
        foreach (var t in listOfTriplets)
        {
            if (TripletCompare(t, triplet))
                return true;
        }
        return false;
    }
    private static bool TripletCompare(int[] a, int[] b)
    {
        for (int i = 0; i < 3; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }
}