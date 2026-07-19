namespace d_multilevel_inheritance;

public class Apple
{
    public int a = 44;
}
public class Ball : Apple
{
    public int b = 10;
}
public class Cat : Ball
{
    public int c = 12;
    public void sum()
    {
        Console.WriteLine("The sum = " + (a + b + c));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cat c1 = new Cat();
        c1.sum();
    }
}