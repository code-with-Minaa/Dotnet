namespace e_greatest_number;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of 1st num :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of 2nd num :");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("The greatest num is " + a);
        }
        else
        {
            Console.WriteLine("The greatest num is " + b);
        }
    }
}
