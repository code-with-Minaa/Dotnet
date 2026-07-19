namespace e_parameterized_constructor;
#nullable disable

class Student
{
    int a,b,c;

    public Student(int m, int n)
    (
        a = m;
        b = n;
    )
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
