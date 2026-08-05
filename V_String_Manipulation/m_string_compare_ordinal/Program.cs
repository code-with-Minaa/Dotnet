namespace m_string_compare_ordinal;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Kathmandu";
        string s2 = "Hello";
        string s3 = "hello";
        string s4 = "Kathmandu";
        Console.WriteLine(string.CompareOrdinal(s1, s2));
        Console.WriteLine(string.CompareOrdinal(s2, s3));
        Console.WriteLine(string.CompareOrdinal(s1, s4));
        Console.WriteLine(s1.CompareTo(s4));
    }
}
