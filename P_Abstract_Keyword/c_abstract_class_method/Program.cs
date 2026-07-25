namespace c_abstract_class_method;

abstract class ABC
{
    public abstract void Calc(int a);
}

class Sum : ABC
{
    public override void Calc(int a)
    {
        Console.WriteLine("The sum = " + (a+a));
    }
}

class Power2 : ABC
{
    public override void Calc (int a)
    {
       Console.WriteLine("The square root of a : " + (a*a));
    }

}

class Power3 : ABC
{
    public override void Calc (int a)
    {
       Console.WriteLine("The cube root of a : " + (a*a*a));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Sum s = new Sum();
        Power2 p2 = new Power2();
        Power3 p3 = new Power3();

        s.Calc(10);
        p2.Calc(22);
        p3.Calc(6);
    }
}
