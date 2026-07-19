namespace b_single_inheritance_constructor;

class BaseClass
{
    public BaseClass()
    {
        Console.WriteLine("Constructor");
    }
    public void hello1()
    {
        Console.WriteLine("Hello from BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public void hello()
    {
        Console.WriteLine("Hello From Derived Class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        DerivedClass d = new DerivedClass();
        d.hello1();
        d.hello();
    }
}
