namespace e_foreach_integer_array;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
