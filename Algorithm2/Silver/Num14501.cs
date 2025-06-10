
namespace Algorithm2.Silver;

public class Num14501
{
    public static void QuitJob()
    {
        int N = int.Parse(Console.ReadLine());
        int[] T = new int[N + 1];
        int[] P = new int[N + 1];
        int[] dp = new int[N + 2];
        
        for (int i = 1; i <= N; i++)
        {
            int[] info = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            T[i] = info[0];
            P[i] = info[1];
        }

        for (int i = N; i >= 1; i--)
        {
            if (i + T[i] <= N + 1)
            {
                dp[i] = Math.Max(P[i] + dp[i + T[i]], dp[i + 1]);
            }
            else
            {
                dp[i] = dp[i + 1];
            }
        }
        Console.WriteLine(dp[1]);
    }
}