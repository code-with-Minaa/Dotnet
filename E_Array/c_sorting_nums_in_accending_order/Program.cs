namespace c_sorting_nums_in_accending_order;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 88, 20, 1, 32, 99, 7 };

        Console.WriteLine("Before Sorting:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Sort array in ascending order
        Array.Sort(numbers);

        Console.WriteLine();
        Console.WriteLine("After Sorting (Ascending Order):");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
