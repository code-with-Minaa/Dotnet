namespace a_virtual_keyword;

class SuperClass
{
    //virtual method
    public virtual int  Calc(int a, int b)
    {
        return (a + b);
    }
}

class SubClass : SuperClass
{
    //redefined
    public override int  Calc(int a, int b)
    {
        return (a + b + 5);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        Console.WriteLine("Redefined result = " + obj.Calc(10,50));
    }
}
