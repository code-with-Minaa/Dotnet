namespace c_implicit;

class Program
{
    static void Main(string[] args)
    {
        byte x = 11;
        int y = x;
        long z = x;

        /* int y = (int)x;
        long z = (long)x; */

        Console.WriteLine("Byte a =" + x);
        Console.WriteLine("Integer b = " + y);
        Console.WriteLine("Long integer c = " + x);
    }
}
