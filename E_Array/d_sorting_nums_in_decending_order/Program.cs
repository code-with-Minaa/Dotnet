namespace d_sorting_nums_in_decending_order;

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

        // Reverse the array to get descending order
        Array.Reverse(numbers);

        Console.WriteLine();
        Console.WriteLine("After Sorting (Descending Order):");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
