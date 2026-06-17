namespace c_value_type_byte;
class Program
{
    static void Main(string[] args)
    {
        byte number = 10;

        // byte is an 8-bit unsigned integer
        Console.WriteLine("Initial value: " + number);

        number++;
        Console.WriteLine("After increment: " + number);

        number = 255;

        Console.WriteLine("Maximum byte value: " + number);

        number++;   // Overflow occurs here
        Console.WriteLine("After overflow: " + number);

        number++;
        Console.WriteLine("Next value: " + number);
    }
}
