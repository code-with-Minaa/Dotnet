namespace a_overloading;

class Nums
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public int add(int a, int b, int c)
    {
        return (a + b + c);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nums obj = new Nums();
        Nums obj1 = new Nums();
        Console.WriteLine("The sum = " + obj.add(20,33));
        Console.WriteLine("The sum = " + obj1.add(20,33,66));

    }
}
