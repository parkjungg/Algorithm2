namespace Algorithm2.Silver;


// Silver 2 A -> B
public class Num16953
{
    public static void AtoB()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int A = numbers[0];
        int B = numbers[1];

        int count = 0;
        
        while (B > A)
        {
            int temp = B;
            if (B % 10 == 1) // 마지막 자리 숫자가 1일 경우 1을 없앰
            {
                B = B / 10;
                count++;
            }
            else if(B % 2 == 0)
            {
                B /= 2;
                count++;
            }
            else
            {
                Console.WriteLine(-1);
                return;
            }
        }

        if (B == A)
        {
            Console.WriteLine(count + 1);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}