namespace i_string_uppercase;

class Program
{
    static void Main(string[] args)
    {
        string string_one = "KaThmanDU";
        string string_two = string_one.ToUpper();
        Console.WriteLine("Original string = " + string_one);
        Console.WriteLine("Converted uppercase string = " + string_two);
    }
}