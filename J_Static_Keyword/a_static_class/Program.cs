namespace a_static_class;
static class Student
{
    public static void Display()
    {
        Console.WriteLine("Welcome to C#");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student.Display();
    }
}
