namespace Algorithm2.Gold;


// Gold 5 CCW
public class Num11758
{
    public static void CCW()
    {
        int[,] arr = new int[3,2];
        for (int i = 0; i < 3; i++)
        {
            int[] dot = Console.ReadLine().Split().Select(int.Parse).ToArray();
            arr[i, 0] = dot[0];
            arr[i, 1] = dot[1];
        }

        int sum = 0;
        
        for (int i = 0; i < 3; i++)
        {
            sum += arr[i, 0] * arr[(i + 1) % 3, 1];
            sum -= arr[i, 1] * arr[(i + 1) % 3, 0];
        }

        if (sum > 0) Console.WriteLine(1);
        else if (sum == 0) Console.WriteLine(0);
        else Console.WriteLine(-1);
        
    }
}