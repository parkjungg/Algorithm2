namespace Algorithm2.Silver;


// Silver 2 N과 M(9)
public class Num15663
{
    private static int N, M;
    private static int[] arr;
    private static int[] selected;
    private static bool[] visited;
    static List<string> result = new List<string>();
    public static void NandM9()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        N = numbers[0];
        M = numbers[1];
        
        arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(arr);

        selected = new int[M];
        visited = new bool[N];
        
        BackTracking(0);
        
        foreach (string result in result.Distinct())
        {
            Console.WriteLine(result);
        }
    }

    private static void BackTracking(int depth)
    {
        if (depth == M)
        {
            result.Add(string.Join(" ", selected));
            return;
        }

        for (int i = 0; i < N; i++)
        {
            if(visited[i]) continue;

            visited[i] = true;
            selected[depth] = arr[i];
            BackTracking(depth + 1);
            visited[i] = false;
        }
    }
}