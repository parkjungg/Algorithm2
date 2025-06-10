namespace Algorithm2.Silver;

public class Num3273
{
    public static void TwoSum()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x = int.Parse(Console.ReadLine());
        int count = 0;

        Array.Sort(arr);
        int startIdx = 0;
        int endIdx = n - 1;

        while (startIdx < endIdx)
        {
            int sum = arr[startIdx] + arr[endIdx];
            if (sum == x)
            {
                count++;
                startIdx++;
                endIdx--;
            }
            else if (sum < x)
            {
                startIdx++;
            }
            else
            {
                endIdx--;
            }
        }
        Console.WriteLine(count);
    }
}


// 1 2 3 5 7 9 10 11 12