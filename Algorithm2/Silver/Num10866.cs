using System.Text;

namespace Algorithm2.Silver;

// Silver 4 Deque
public class Num10866
{
    public static void Deque()
    {
        LinkedList<int> deque = new LinkedList<int>();
        int N = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < N; i++)
        {
            string[] command = Console.ReadLine().Split();
            if (command[0] == "push_back" || command[0] == "push_front")
            {
                int number = int.Parse(command[1]);
                if (command[0] == "push_front")
                {
                    deque.AddFirst(number);
                }
                else if (command[0] == "push_back")
                {
                    deque.AddLast(number);
                }
            }
            else
            {
                if (command[0] == "front")
                {
                    if(deque.Count == 0) sb.AppendLine("-1");
                    else
                    {
                        sb.AppendLine(deque.First.Value.ToString());
                    }
                   
                }
                else if (command[0] == "back")
                {
                    if(deque.Count == 0) sb.AppendLine("-1");
                    else
                    {
                        sb.AppendLine(deque.Last.Value.ToString());
                    }
                }
                else if (command[0] == "size")
                {
                    sb.AppendLine(deque.Count.ToString());
                }
                else if (command[0] == "empty")
                {
                    if (deque.Count == 0) sb.AppendLine("1");
                    else sb.AppendLine("0");
                }
                else if (command[0] == "pop_front")
                {
                    if(deque.Count == 0) sb.AppendLine("-1");
                    else
                    {
                        sb.AppendLine(deque.First.Value.ToString());
                        deque.RemoveFirst();
                    }
                    
                }
                else if (command[0] == "pop_back")
                {
                    if(deque.Count == 0) sb.AppendLine("-1");
                    else
                    {
                        sb.AppendLine(deque.Last.Value.ToString());
                        deque.RemoveLast();
                    }
                }
            }
        }
        Console.WriteLine(sb.ToString());
    }
}