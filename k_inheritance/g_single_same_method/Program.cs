namespace g_single_same_method;

class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hi, from Superclass.");
    }
}
class SubClass : SuperClass
{
    public new void hi()
    {
        Console.WriteLine("hi, from SubClass.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubClass s1 = new SubClass();
        SuperClass s2 = new SubClass();
        s1.hi();
        s2.hi();
    }
}
