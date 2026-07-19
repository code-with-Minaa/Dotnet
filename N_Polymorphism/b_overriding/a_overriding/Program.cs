namespace a_overriding;

class Teacher
{
    public void hello()
    {
        Console.WriteLine("Hello dear students.");
    }
}

class Student : Teacher
{
    public new void hello()
    {
        Console.WriteLine("Hello Teacher.");
    }
}
class Program
{
    static void Main(string[] args)
    {
       Student s1 = new Student();
       s1.hello();
    }
}
