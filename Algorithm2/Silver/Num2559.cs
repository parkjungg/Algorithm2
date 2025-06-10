namespace Algorithm2.Silver;

public class Num2559
{
    public static void NumberSequence()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = numbers[0];
        int K = numbers[1];
        
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int sum = 0;

        for (int i = 0; i < K; i++)
        {
            sum += arr[i];
        }

        int max = sum;

        for (int i = K; i < N; i++)
        {
            sum = sum - arr[i - K] + arr[i];
            if(sum > max) max = sum;
        }
        Console.WriteLine(max);
    }
}