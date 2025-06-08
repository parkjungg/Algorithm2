namespace Algorithm2.Silver;

public class Num2941
{
    public static void CroatiaAlphabet()
    {
        string word = Console.ReadLine();
        string[] alphabet = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

        foreach (string s in alphabet)
        {
            word = word.Replace(s, "!");
        }
        Console.WriteLine(word.Length);
    }
}