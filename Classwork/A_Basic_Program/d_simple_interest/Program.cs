namespace i_simple_interest;

class Program
{
    static void Main(string[] args)
    {
        double p = 12000;
        double t = 3;
        double r = 5;
        double si = (p*t*r)/100;
        Console.WriteLine("Simple Interest :" + si);
    }
}
