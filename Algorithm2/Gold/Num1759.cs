namespace Algorithm2.Gold;


// Gold 5 암호 만들기
public class Num1759
{
    private static int L, C;
    private static char[] input;
    private static char[] password;
    static List<string> result = new List<string>();
    
    public static void MakePassword()
    {
        var line = Console.ReadLine().Split();
        L = int.Parse(line[0]);
        C = int.Parse(line[1]);

        input = Console.ReadLine().Split().Select(char.Parse).ToArray();
        Array.Sort(input);
        password = new char[L];
        
        BackTracking(0, 0);

        foreach (var s in result)
        {
            Console.WriteLine(s);
        }
    }

    private static void BackTracking(int depth, int start)
    {
        if (depth == L)
        {
            if (IsValid(password))
            {
                result.Add(new string(password));
            }
            return;
        }

        for (int i = start; i < C; i++)
        {
            password[depth] = input[i];
            BackTracking(depth + 1, i + 1);
        }
    }

    private static bool IsValid(char[] pw)
    {
        int vowels = 0;
        int consonants = 0;
        foreach (char c in pw)
        {
            if ("aeiou".Contains(c))
            {
                vowels++;
            }
            else
            {
                consonants++;
            }
        }
        return vowels >= 1 && consonants >= 2;
    }
}