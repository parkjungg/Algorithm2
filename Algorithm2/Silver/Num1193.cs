namespace Algorithm2.Silver;

public class Num1193
{
    public static void FindFountain()
    {
        int X = int.Parse(Console.ReadLine());
        int line = 1;

        while (X > line)
        {
            X -= line;
            line += 1;
        }

        int a = 0;
        int b = 0;
        
        if (line % 2 == 1)
        {
            a = X;
            b = line - X + 1;
        }
        else if (line % 2 == 0)
        { 
            a = line - X + 1; 
            b = X;
        }

        Console.WriteLine($"{b}/{a}");
    }
}