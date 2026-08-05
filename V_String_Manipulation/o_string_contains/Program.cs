namespace o_string_contains;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "kathmandu";
        string s2 = "kath";
        string s3 = "mandu";
        string s4 = "thma";

        Console.WriteLine(s1.Contains(s2));
        Console.WriteLine(s1.Contains(s3));
        Console.WriteLine(s1.Contains(s4));
    }
}