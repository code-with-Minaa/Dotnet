namespace g_hashset_t;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> myIntHash = new HashSet<int>() {12,7,98,63,1,7,96};
        Console.WriteLine("Elements in hashset :");
        foreach (var item in myIntHash)
        {
            Console.WriteLine(item);
        }
    }
}
