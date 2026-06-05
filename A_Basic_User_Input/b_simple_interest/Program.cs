namespace b_simple_interest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of P:");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of T:");
        double t = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of R:");
        double r = Convert.ToDouble(Console.ReadLine());

        double si = (p * t * r) / 100;

        Console.WriteLine("Simple Interest = " + si);
    }
}

