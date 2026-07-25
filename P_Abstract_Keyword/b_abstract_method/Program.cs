namespace b_abstract_method;

class Nums
{
    public virtual int Calc(int a , int b)
    {
        return (a + b);
    }
}

class AbsDemo : Nums
{
    public override int Calc(int a , int b)
    {
        return (a * b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        AbsDemo obj = new AbsDemo();
        int result = obj.Calc(12,13);
        Console.WriteLine("The result = " + result);
    }
}
