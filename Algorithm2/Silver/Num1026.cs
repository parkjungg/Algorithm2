namespace Algorithm2.Silver;


// Silver 4 보물
public class Num1026
{
    public static void Treasure()
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        int[] B = new int[N];
        
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < N; i++) 
        {
            A[i] = numbers[i];
        }

        numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < N; i++)
        {
            B[i] = numbers[i];
        }
        
        Array.Sort(A);
        Array.Sort(B, (x, y) => y.CompareTo(x));
        
        int result = 0;
        for (int i = 0; i < N; i++)
        {
            result += A[i] * B[i];
        }
        Console.WriteLine(result);
    }
}