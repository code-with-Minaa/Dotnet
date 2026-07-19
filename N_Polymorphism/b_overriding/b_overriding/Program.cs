namespace b_overriding;

class Teacher
{
    public virtual void hello()
    {
        Console.WriteLine("Hello dear students.");
    }
}

class Student : Teacher
{
    public override void hello()
    {
        Console.WriteLine("Hello Teacher.");
    }
}
class Program
{
    static void Main(string[] args)
    {
       Teacher t1 = new Student();
       t1.hello();
    }
}
