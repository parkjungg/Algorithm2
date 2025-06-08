namespace Algorithm2.Silver;

public class Num1316
{
    public static void GroupWordChecker()
    {
        int N = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < N; i++)
        {
           string s = Console.ReadLine();
           if (CheckWord(s))
           {
               count++;
           }
        }
        Console.WriteLine(count);
    }

    private static bool CheckWord(string s)
    {
        bool[] seen = new bool[26];
        char prev = '\0';

        foreach (char c in s)
        {
            if (c != prev)
            {
                if (seen[c - 'a']) return false;
                seen[c - 'a'] = true;
            }

            prev = c;
        }
        return true;
    }
}