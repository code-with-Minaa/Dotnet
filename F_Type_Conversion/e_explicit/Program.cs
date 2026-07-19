namespace e_explicit;
class Program
{
    static void Main(string[] args)
    {
        int x = 110;
        byte y = (byte)x; // careful about the range of byte i.e 0-255
        Console.WriteLine("Integer value = " + x);
        Console.WriteLine("Converted byte value = " + y);
    }
}
