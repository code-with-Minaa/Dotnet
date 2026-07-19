namespace b_multiple_inheritance;

interface IFather
{
    public void FatherMethod();
}
interface IMother
{
    public void MotherMethod();
}

class Child : IFather, IMother // Child class cannot have multiple parent classes.
{
    public void FatherMethod()
    {
        Console.WriteLine("Hello from your dad.");
    }

    public void MotherMethod()
    {
        Console.WriteLine("Hello from your mother.");
    }
    public void ChildMethod()
    {
        Console.WriteLine("Hello dad and mom");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.ChildMethod();
        c1.FatherMethod();
        c1.MotherMethod();
    }
}
