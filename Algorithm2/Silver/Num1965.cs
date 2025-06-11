namespace Algorithm2.Silver;

public class Num1965
{
    public static void PutInBox()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] dp = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[j] < arr[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        Console.WriteLine(dp.Max());
    }
}