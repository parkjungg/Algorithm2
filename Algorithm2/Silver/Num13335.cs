namespace Algorithm2.Silver;

// Silver 1
public class Num13335
{
    public static void Bridge()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = numbers[0];
        int w = numbers[1];
        int L = numbers[2];

        int[] weight = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < w; i++) queue.Enqueue(0);

        int time = 0;
        int totalWeight = 0;
        int truckIdx = 0;

        while (truckIdx < n)
        {
            time++;
            totalWeight -= queue.Dequeue();

            if (totalWeight + weight[truckIdx] <= L)
            {
                queue.Enqueue(weight[truckIdx]);
                totalWeight += weight[truckIdx];
                truckIdx++;
            }
            else
            {
                queue.Enqueue(0);
            }
        }

        Console.WriteLine(time + w);
    }
}