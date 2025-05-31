namespace Algorithm2.Silver;


// Silver 1
public class Num1743
{
    private static int[,] ground;
    private static bool[,] visited;
    private static int N, M;
    private static int[] dx = { -1, 1, 0, 0 };
    private static int[] dy = { 0, 0, 1, -1 };
    public static void Garbage()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        N = numbers[0];
        M = numbers[1];
        int K = numbers[2];

        ground = new int[N + 1, M + 1];
        visited = new bool[N + 1, M + 1];
        
        for (int i = 0; i < K; i++)
        {
            int[] garPos = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ground[garPos[0], garPos[1]] = 1;
        }

        int max = 0;
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= M; j++)
            {
                if (ground[i, j] == 1)
                {
                    int size = DFS(i, j);
                    max = Math.Max(max, size);
                }
            }
        }
        Console.WriteLine(max);
    }

    private static int DFS(int x, int y)
    {
        Stack<(int x, int y)> stack = new Stack<(int, int)>();
        stack.Push((x,y));
        visited[x, y] = true;

        int size = 1;
        while (stack.Count > 0)
        {
            (int nx, int ny) = stack.Pop();
            for (int i = 0; i < 4; i++)
            {
                int cx = nx + dx[i];
                int cy = ny + dy[i];
                if (cx >= 1 && cx <= N && cy >= 1 && cy <= M && !visited[cx, cy] && ground[cx, cy] == 1)
                {
                    stack.Push((cx, cy));
                    visited[cx, cy] = true;
                    size++;
                }
            }
        }
        return size;
    }
}