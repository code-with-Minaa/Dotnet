namespace k_add_two_user_input_nums;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number : ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = (a+b);
        Console.WriteLine("Sum of two user input numbers is : " + sum);
    }
}
