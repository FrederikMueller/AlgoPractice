namespace Algorithms.Easy;
public class MinimumWaitingTime
{
    /*
    Fully understand the problem
        Return the minimum amount of TOTAL waiting time for all of the queries. Each query has to wait until every query before it is finished.
        One  query at a time, order can be changed (in place).
    Look for potential simplifications of the problem
        Minimize the total amount of time we have to wait, i.e. sort the array and let fast queries execute first.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Sort the array. Sum the query times as you iterate over the array and add that to the total. Return the total.
    Then implement the simplified conceptual solution step by step
        Easiest to conceptualize with a totalWaitingTime and a currentSum variable.
    Optimization. Big O analysis. Amortization?
        Time = n log n
        Space = 1
    Video Notes:
        You can also add to the total by looking how many items in the array are left and add the current waiting time times the number to the total.
    */

    public int GetMinimumWaitingTime(int[] queries)
    {
        Array.Sort(queries);
        int totalWaitingTime = 0;
        int currentSum = 0;

        for (int i = 0; i < queries.Length; i++)
        {
            totalWaitingTime += currentSum;
            currentSum += queries[i];
        }
        return totalWaitingTime;
    }
}