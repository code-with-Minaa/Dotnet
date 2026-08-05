namespace l_string_compare;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Kathmandu";
        string s2 = "hello";
        string s3 = "Hello";
        string s4 = "Kathmandu";
        Console.WriteLine(string.Compare(s1, s2));
        Console.WriteLine(string.Compare(s2, s3));
        Console.WriteLine(string.Compare(s1, s4)); // i. e. 0
    }
}