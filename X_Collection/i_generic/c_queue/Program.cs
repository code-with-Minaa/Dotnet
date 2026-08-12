namespace c_queue;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(17);
        nums.Enqueue(18);
        nums.Enqueue(89);
        nums.Enqueue(20);
        nums.Enqueue(54);
        nums.Dequeue();
        
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine(nums.Contains(89)); //true
        Console.WriteLine(nums.Contains(30)); //false
    }
}
