using System.Text;

namespace e_string_builder;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello, Sanothimi",20);
        s.Replace("Sanothimi","Bhaktapur");
        Console.WriteLine(s);
    }
}
