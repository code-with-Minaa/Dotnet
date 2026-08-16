namespace c_stack;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push("Sajana");
        stack.Push(17);
        stack.Push("56");

        Console.WriteLine("Queue Elements are :");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        stack.Pop();
        Console.WriteLine("Queue After Pop :");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    
    }
}
