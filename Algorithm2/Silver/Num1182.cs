namespace Algorithm2.Silver;

public class Num1182
{
    private static int N, S;
    private static int[] arr;
    private static int count = 0;
    
    public static void SubsequenceSum()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        N = nums[0];
        S = nums[1];
        
        arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        BackTracking(0, 0);
        Console.WriteLine(count);
    }

    private static void BackTracking(int start, int sum)
    {
        if (start == N)
            return;
        sum += arr[start];

        if (sum == S)
            count++;

        BackTracking(start + 1, sum);
        BackTracking(start + 1, sum - arr[start]);
    }
}