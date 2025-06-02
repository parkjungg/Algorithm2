namespace Algorithm2.Gold;

public class Num6593
{
    private static int L, R, C;
    private static bool[,,] visited;
    private static int[] dx = { 1, -1, 0, 0, 0, 0};
    private static int[] dy = { 0, 0, 1, -1, 0, 0};
    private static int[] dz = { 0, 0, 0, 0, 1, -1};
    private static char[,,] map;
    public static void Building()
    {
        while (true)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            L = info[0];
            R = info[1]; 
            C = info[2];
            if (L == 0 && R == 0 && C == 0) return;

            map = new char[L, R, C];
            int startX = -1, startY = -1, startZ = -1;
            
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    string line = Console.ReadLine();
                    for (int k = 0; k < C; k++)
                    {
                        map[i, j, k] = line[k];
                        if (line[k] == 'S')
                        {
                            startX = j;
                            startY = k;
                            startZ = i;
                        }
                    }
                }
                Console.ReadLine();
            }
            BFS(startX, startY, startZ);
        }
    }

    private static void BFS(int startX, int startY, int startZ)
    {
        Queue<(int x, int y, int z, int time)> queue = new Queue<(int x, int y, int z, int time)>();
        visited = new bool[L, R, C];
        queue.Enqueue((startX, startY, startZ, 0));
        visited[startZ, startX, startY] = true;

        while (queue.Count > 0)
        {
            (int x, int y, int z, int time) = queue.Dequeue();
            if (map[z, x, y] == 'E')
            {
                Console.WriteLine($"Escaped in {time} minute(s).");
                return;
            }

            for (int i = 0; i < 6; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                int nz = z + dz[i];

                if (nx >= 0 && nx < R && ny >= 0 && ny < C && nz >= 0 && nz < L
                    && !visited[nz, nx, ny] && map[nz, nx, ny] != '#')
                {
                    visited[nz, nx, ny] = true;
                    queue.Enqueue((nx, ny, nz, time + 1));
                }
            }
        }
        Console.WriteLine("Trapped!");
    }
}