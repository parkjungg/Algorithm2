namespace Algorithm2.Silver;

public class Num2563
{
    public static void ColorPaper()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] arr = new int[100, 100];
        int total = 0;
        
        for (int i = 0; i < N; i++)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = nums[0];
            int y = nums[1];

            for (int j = y; j < y + 10; j++)
            {
                for (int k = x; k < x + 10; k++)
                {
                    arr[j, k] = 1;
                }
            }
        }

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                if (arr[i, j] == 1)
                {
                    total++;
                }
            }
        }
        Console.WriteLine(total);
    }
}