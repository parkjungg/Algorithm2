namespace Algorithm2.Gold;


// Gold 5 센서
public class Num2212
{
    public static void Sensor()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        
        string[] input = Console.ReadLine().Split();
        int[] sensors = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            sensors[i] = int.Parse(input[i]);
        }
        Array.Sort(sensors);
        
        int[] dist = new int[N - 1];
        for (int i = 0; i < N - 1; i++)
        {
            dist[i] = sensors[i+1] - sensors[i];
        }
        Array.Sort(dist, (x, y) => y.CompareTo(x));

        int ans = 0;
        for (int i = K - 1; i < dist.Length; i++)
        {
            ans += dist[i];
        }
        Console.WriteLine(ans);
    }
}
// 2 3 0 1 2
// 3 2 2 1 0