namespace a_sealed;

//sealed class SuperClass
class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hii from SuperClass.");
    }
}

class SubClass : SuperClass
{
    public void hello()
    {
        Console.WriteLine("Hello from SubClass.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass s1 = new SubClass();
        s1.hi();
        s1.hello();
    }
}
