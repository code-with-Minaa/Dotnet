namespace b_overloading_sequence_of_parameter;

class Nums
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public double add(double a, double b, double c)
    {
        return (a + b + c);
    }
    public string add(string a, string b)
    {
        return (a + b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nums obj = new Nums();
        Nums obj1 = new Nums();
        Console.WriteLine("The sum = " + obj.add(20,33));
        Console.WriteLine("The sum = " + obj.add(20.11,33.55,66.99));
        Console.WriteLine("The sum = " + obj.add("mina","karki"));

    }
}
