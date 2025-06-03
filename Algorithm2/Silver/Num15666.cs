namespace Algorithm2.Silver;



// Silver 2 N과 M(12)
public class Num15666
{
    private static int N, M;
    private static int[] arr;
    private static int[] selected;
    private static bool[] visited;
    private static List<string> result = new List<string>();
    public static void NandM12()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        N = numbers[0];
        M = numbers[1];
        
        arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(arr);
        
        selected = new int[M];
        visited = new bool[N];

        BackTracking(0, 0);

        foreach (string result in result.Distinct())
        {
            Console.WriteLine(result);
        }
    }

    private static void BackTracking(int depth, int start)
    {
        if (depth == M)
        {
            result.Add(string.Join(" ", selected));
            return;
        }

        int prev = -1;
        for (int i = start; i < N; i++)
        {
            if(arr[i] == prev) continue;
            selected[depth] = arr[i];
            prev = arr[i];
            BackTracking(depth + 1, i);

        }
    }
}