namespace Algorithm2.Gold;


// Gold 5 내려가기
public class Num2096
{
    public static void GoDown()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] arr = new int[N, 3];

        for (int i = 0; i < N; i++)
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = line[j];
            }
        }

        int[,] maxDp = new int[2, 3];
        int[,] minDp = new int[2, 3];

        for (int i = 0; i < 3; i++)
        {
            maxDp[0, i] = arr[0, i];
            minDp[0, i] = arr[0, i];
        }

        for (int i = 1; i < N; i++)
        {
            maxDp[1, 0] = arr[i, 0] + Math.Max(maxDp[0, 0], maxDp[0, 1]);
            maxDp[1, 1] = arr[i, 1] + Math.Max(Math.Max(maxDp[0, 0], maxDp[0, 1]), maxDp[0, 2]);
            maxDp[1, 2] = arr[i, 2] + Math.Max(maxDp[0, 1], maxDp[0, 2]);

            minDp[1, 0] = arr[i, 0] + Math.Min(minDp[0, 0], minDp[0, 1]);
            minDp[1, 1] = arr[i, 1] + Math.Min(Math.Min(minDp[0, 0], minDp[0, 1]), minDp[0, 2]);
            minDp[1, 2] = arr[i, 2] + Math.Min(minDp[0, 1], minDp[0, 2]);

            for (int j = 0; j < 3; j++)
            {
                maxDp[0, j] = maxDp[1, j];
                minDp[0, j] = minDp[1, j];
            }
        }
        int maxResult = Math.Max(Math.Max(maxDp[0, 0], maxDp[0, 1]), maxDp[0, 2]);
        int minResult = Math.Min(Math.Min(minDp[0, 0], minDp[0, 1]), minDp[0, 2]);
        
        Console.WriteLine($"{maxResult} {minResult}");
    }
}