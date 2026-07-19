namespace a_single_inheritance;

class BaseClass
{
    public void hello1()
    {
        Console.WriteLine("Hello from BaseClass.");
    }
}

class DerivedClass : BaseClass
{
    public void hello()
    {
        Console.WriteLine("Hello From Derived Class.");
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
