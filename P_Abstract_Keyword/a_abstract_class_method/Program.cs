namespace a_abstract_class;

abstract class Nepal
{
    public abstract void hi();
}

class Kathmandu : Nepal
{
    public override void hi()
    {
        Console.WriteLine("Hello Kathmandu Nepal.");
    }
}

class Bhaktapur : Nepal
{
    public override void hi()
    {
        Console.WriteLine("Hello Bhaktapur Nepal.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nepal n;
        n = new Kathmandu();
        n.hi();
        n = new Bhaktapur();
        n.hi();
    }
}
