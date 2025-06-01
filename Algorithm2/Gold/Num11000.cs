namespace Algorithm2.Gold;


// Gold 5 강의실 배정
public class Num11000
{
    public static void LectureRoom()
    {
        int N = int.Parse(Console.ReadLine());
        var lectures = new List<(int start, int end)>();

        for (int i = 0; i < N; i++)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            lectures.Add((arr[0], arr[1]));
        }
        
        lectures.Sort((a, b) => a.start.CompareTo(b.start));

        var pq = new PriorityQueue<int, int>();
        pq.Enqueue(lectures[0].end, lectures[0].end);

        for (int i = 1; i < N; i++)
        {
            if (pq.Peek() <= lectures[i].start)
            {
                pq.Dequeue();
            }
            pq.Enqueue(lectures[i].end, lectures[i].end);
        }
        Console.WriteLine(pq.Count);
    }
}