namespace b_queue;
using System.Collections;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue("Mina");
        queue.Enqueue(12);
        queue.Enqueue(12.30);
        queue.Enqueue(true);

        Console.WriteLine("Queue Elements are :");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }


        queue.Dequeue();
        Console.WriteLine("Queue After Dequeue :");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("First element is {0}",queue.Peek());

        if(queue.Contains(12))
        {
            Console.WriteLine("The element is in the queue.");
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}
