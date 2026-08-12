using System.Text;

namespace g_string_builder;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello Sanothimi");
        string str = s.ToString();
        Console.WriteLine(s);
    }
}
