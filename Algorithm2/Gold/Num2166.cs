namespace Algorithm2.Gold;

// Gold 5 다각형의 면적
public class Num2166
{
    public static void PolygonArea()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] arr = new int[N, 2];
        for (int i = 0; i < N; i++)
        {
            int[] pos = Console.ReadLine().Split().Select(int.Parse).ToArray();
            arr[i, 0] = pos[0];
            arr[i, 1] = pos[1];
        }

        double sum = 0;

        for (int i = 0; i < N; i++)
        {
            sum += (double)arr[i, 0] * arr[(i + 1) % N, 1];
            sum -= (double)arr[i, 1] * arr[(i + 1) % N, 0];
        }
        Console.WriteLine($"{Math.Abs(sum) / 2:0.0}");

    }
}

