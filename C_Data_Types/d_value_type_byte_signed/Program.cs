namespace d_value_type_byte_signed;

class Program
{
    static void Main(string[] args)
    {
        sbyte value = 125;

        // sbyte is an 8-bit signed integer
        Console.WriteLine("Initial value: " + value);

        value++;
        Console.WriteLine("After first increment: " + value);

        value++;
        Console.WriteLine("Maximum value reached: " + value);

        value++;   // Overflow occurs here
        Console.WriteLine("After overflow: " + value);

        value++;
        Console.WriteLine("Next value: " + value);
    }
}
