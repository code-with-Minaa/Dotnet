using System.Text;

namespace f_string_builder;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";
        StringBuilder s = new StringBuilder(str);
        Console.WriteLine(s);
    }
}
