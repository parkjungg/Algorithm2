namespace Algorithm2.Silver;

public class Num11055
{
    public static void BiggestSubsequence()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] dp = new int[N];

        for (int i = 0; i < N; i++)
        {
            dp[i] = arr[i];
            for (int j = 0; j < i; j++)
            {
                if (arr[j] < arr[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + arr[i]);
                }
            }
        }
        Console.WriteLine(dp.Max());
    }
}