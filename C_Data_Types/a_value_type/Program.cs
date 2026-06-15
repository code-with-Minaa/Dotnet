namespace a_value_type;

class Program
{
    static void Main(string[] args)
    {
        char grade = 'a'; // char is a single character, enclosed in single quotes
        int salary = 50000; // int is a whole number, without a decimal point
        short num1 = 21; // short is a smaller whole number, with a smaller range than int
        long num2 = 101010; // long is a larger whole number, with a larger range than int
        uint ui = 86; // uint is an unsigned integer, with a larger range than int
        ushort us = 76; // ushort is an unsigned short, with a smaller range than short
        ulong ul = 6546548; // ulong is an unsigned long, with a larger range than long
        double d = 2.585468; // double is a floating-point number with double precision
        float f = 5.478487f; // float is a floating-point number with single precision
        decimal dc = 55.9m; // decimal is a floating-point number with high precision, often used for financial calculations


        Console.WriteLine("Character = " + grade); 
        Console.WriteLine("Integer = " + salary);
        Console.WriteLine("Short = " + num1);
        Console.WriteLine("Long = " + num2);
        Console.WriteLine("Unsigned integer = " + ui);
        Console.WriteLine("Unsigned short = " + us);
        Console.WriteLine("Unsigned long = " + ul);
        Console.WriteLine("Double = " + d);
        Console.WriteLine("Float = " + f);
        Console.WriteLine("Decimal = " + dc);
    }
}
