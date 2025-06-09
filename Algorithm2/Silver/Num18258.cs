using System.Text;

namespace Algorithm2.Silver;

public class Num18258
{
    public static void Queue()
    {
        Queue<int> queue = new Queue<int>();
        StringBuilder sb = new StringBuilder();
        
        int N = int.Parse(Console.ReadLine());
        int backValue = -1;
        
        for (int i = 0; i < N; i++)
        {
            String[] command = Console.ReadLine().Split();
            if (command[0] == "push")
            {
                int num = int.Parse(command[1]);
                queue.Enqueue(num);
                backValue = num;
            }
            else if (command[0] == "pop")
            {
                if (queue.Count == 0) sb.AppendLine("-1");
                else sb.AppendLine(queue.Dequeue().ToString());
            }
            else if (command[0] == "size")
            {
                sb.AppendLine(queue.Count().ToString());
            }
            else if (command[0] == "empty")
            {
                if (queue.Count == 0) sb.AppendLine("1");
                else sb.AppendLine("0");
            }
            else if (command[0] == "front")
            {
                if(queue.Count == 0) sb.AppendLine("-1");
                else sb.AppendLine(queue.Peek().ToString());
            }
            else if (command[0] == "back")
            {
                if (queue.Count == 0) sb.AppendLine("-1");
                else sb.AppendLine(backValue.ToString());
            }
        }
        Console.WriteLine(sb.ToString());
    }
}