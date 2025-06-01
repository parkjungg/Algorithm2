namespace Algorithm2.Gold;



// Gold 5 A와 B
public class Num12904
{
    public static void AandB()
    {
        string S = Console.ReadLine();
        string T = Console.ReadLine();

        while (S.Length != T.Length)
        {
            if (T.EndsWith('A'))
            {
               T = T.Remove(T.Length - 1);
            }
            else if (T.EndsWith('B'))
            {
               T = T.Remove(T.Length - 1);
               char[] arr = T.ToCharArray();
               Array.Reverse(arr);
               T = new string(arr);
            }
        }

        Console.WriteLine(S == T ? 1 : 0);
    }
}