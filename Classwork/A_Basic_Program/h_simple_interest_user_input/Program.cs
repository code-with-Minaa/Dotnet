namespace l_si_user_input;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of P:");
        int p = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of T:");
        int t = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of R:");
        int r = Convert.ToInt32(Console.ReadLine());

        int si = (p * t * r) / 100;

        Console.WriteLine("Simple Interest = " + si);
    }
}
