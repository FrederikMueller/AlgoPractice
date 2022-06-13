namespace Algorithms.Medium;
public class LRUCache
{
    /*
        	Queue to represent the order of things added/accessed.
		    dictionary for storing each element's number of occurences in the queue.

	        If the element you want to store has count = 0 in the dict, then you can add it to the queue.
	        Check if queue capacity is hit, if yes:
	        Check the first (oldest) element of the queue. If count is 1 for that element, remove it. Enqueue the new one.
            If no: just add it without removing something
    */

    private Dictionary<int, int> values;
    private Dictionary<int, int> count;
    private Queue<int> order;
    private int capacity;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;

        values = new Dictionary<int, int>(capacity);
        count = new Dictionary<int, int>(capacity);
        order = new Queue<int>(capacity);
    }

    public int Get(int key)
    {
        if (values.ContainsKey(key))
        {
            order.Enqueue(key);
            count[key]++;
            return values[key];
        }
        else
            return -1;
    }

    public void Put(int key, int value)
    {
        if (values.ContainsKey(key))
        {
            values[key] = value;
            order.Enqueue(key);
            count[key]++;

            return;
        }

        if (values.Count < capacity)
        {
            values.Add(key, value);
            order.Enqueue(key);
            count.Add(key, 1);
            Console.WriteLine($"total number of values: {values.Count}.");
        }
        else
        {
            while (true)
            {
                int candidate = order.Dequeue();
                if (count[candidate] <= 1)
                {
                    values.Remove(candidate);
                    count.Remove(candidate);

                    values.Add(key, value);
                    order.Enqueue(key);
                    count.Add(key, 1);
                    Console.WriteLine($"Removed {candidate}. Added {key}.");

                    break;
                }
                else
                {
                    count[candidate]--;
                }
            }
        }
    }
}