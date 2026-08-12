namespace d_queue_t_string;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>();
        names.Enqueue("Ram");
        names.Enqueue("Shyam");
        names.Enqueue("Hari");
        names.Enqueue("Rita");
        names.Enqueue("Gita");
        names.Enqueue("Goma");
        names.Enqueue("Rama");
        Console.WriteLine("The number of elements in the queue : " + names.Count);
        Console.WriteLine("The first element in he queue : " + names.Peek());

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
