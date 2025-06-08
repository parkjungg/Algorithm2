namespace Algorithm2.Silver;

public class Num1427
{
    public static void SortInside()
    {
        string s = Console.ReadLine();
        char[] nums = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            nums[i] = s.ToCharArray()[i];
        }
        
        Array.Sort(nums, (x, y) => y.CompareTo(x));
        foreach (var n in nums)
        {
            Console.Write(n);
        }
        
    }
}