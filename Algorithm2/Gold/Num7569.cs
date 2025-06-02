namespace Algorithm2.Gold;



// Gold 5 토마토
public class Num7569
{
    private static int M, N, H;
    private static bool[,,] visited;
    private static int[] dx = { 1, -1, 0, 0, 0, 0 };
    private static int[] dy = { 0, 0, 1, -1, 0, 0 };
    private static int[] dz = { 0, 0, 0, 0, 1, -1 };
    private static int[,,] box;
    
    public static void Tomato()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        M = input[0];
        N = input[1];
        H = input[2];

        box = new int[M, N, H];
        Queue<(int x,int y , int z, int day)> queue = new Queue<(int,int,int,int)>();

        visited = new bool[M, N, H];
        
        for (int i = 0; i < H; i++)
        {
            for (int j = 0; j < N; j++)
            {
                int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int k = 0; k < M; k++)
                {
                    box[k, j, i] = input2[k];
                    if (box[k, j, i] == 1)
                    {
                        queue.Enqueue((k, j, i, 0));
                    }
                }
            }
        }

        int day = BFS(queue);

        for (int i = 0; i < H; i++)
        {
            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < M; k++)
                {
                    if (box[k, j, i] == 0)
                    {
                        Console.Write(-1);
                        return;
                    }
                    
                }
            }
        }
        Console.WriteLine(day);
    }

    private static int BFS(Queue<(int x, int y, int z, int day)> queue)
    {
        int maxDay = 0;
        
        while (queue.Count > 0)
        {
            (int x, int y, int z, int curDay) = queue.Dequeue();
            maxDay = Math.Max(maxDay, curDay);
            for (int i = 0; i < 6; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                int nz = z + dz[i];

                if (nx >= 0 && nx < M && ny >= 0 && ny < N && nz >= 0 && nz < H
                    && !visited[nx, ny, nz] && box[nx, ny, nz] == 0)
                {
                    visited[nx, ny, nz] = true;
                    box[nx, ny, nz] = 1;
                    queue.Enqueue((nx, ny, nz, curDay + 1));
                }
                
            }
        }
        return maxDay;
    }
}