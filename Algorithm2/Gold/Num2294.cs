namespace Algorithm2.Gold;

public class Num2294
{
    public static void Coin2()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = numbers[0];
        int k = numbers[1];

        int[] coins = new int[n];
        int[] dp = new int[k + 1];
        Array.Fill(dp, 10001);
        dp[0] = 0;
        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(Console.ReadLine());
            if(!coins.Contains(value))
            {
                coins[i] = value;
            }
        }

        foreach (int coin in coins)
        {
            for (int i = coin; i <= k; i++)
            {
                dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
            }
        }

        if (dp[k] == 10001)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(dp[k]);
        }
    }
}