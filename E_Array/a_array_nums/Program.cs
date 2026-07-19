namespace a_array_nums;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 15, 28, 43, 67, 81, 95, 55};

        foreach (var item in myArray)
        {
            Console.Write("{0}\t", item);
        }
    }
}
