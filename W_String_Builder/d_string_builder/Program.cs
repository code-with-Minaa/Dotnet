using System.Text;

namespace d_string_builder;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello, Welcomr to Hamro Campus",20);
        s.Remove(6,9);
        Console.WriteLine(s);
    }
}
