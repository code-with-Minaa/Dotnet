namespace g_data_types;

class Program
{
    static void Main(string[] args)
    {
        // Stores true or false
        bool isStudent = true;

        // Stores a single character
        char grade = 'A';

        // Stores small positive integers (0 to 255)
        byte age = 20;

        // Stores small signed integers (-128 to 127)
        sbyte temperature = -10;

        // Stores short integers
        short marks = 1500;

        // Stores positive short integers
        ushort quantity = 500;

        // Stores integers
        int salary = 25000;

        // Stores positive integers
        uint population = 100000;

        // Stores large integers
        long distance = 9876543210;

        // Stores large positive integers
        ulong stars = 12345678901234;

        // Stores decimal numbers (single precision)
        float pi = 3.14f;

        // Stores decimal numbers (double precision)
        double percentage = 95.75;

        // Stores high-precision decimal values
        decimal price = 199.99m;

        // Stores text
        string name = "Suman";

        // Stores any type of value
        object data = "Hello";

        Console.WriteLine("Bool: " + isStudent);
        Console.WriteLine("Char: " + grade);
        Console.WriteLine("Byte: " + age);
        Console.WriteLine("SByte: " + temperature);
        Console.WriteLine("Short: " + marks);
        Console.WriteLine("UShort: " + quantity);
        Console.WriteLine("Int: " + salary);
        Console.WriteLine("UInt: " + population);
        Console.WriteLine("Long: " + distance);
        Console.WriteLine("ULong: " + stars);
        Console.WriteLine("Float: " + pi);
        Console.WriteLine("Double: " + percentage);
        Console.WriteLine("Decimal: " + price);
        Console.WriteLine("String: " + name);
        Console.WriteLine("Object: " + data);
    }
}
