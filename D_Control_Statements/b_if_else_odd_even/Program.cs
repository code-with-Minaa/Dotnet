namespace b_if_else_odd_even;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a number to check whether the nummber is odd or even : ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even." + number);
        }
        else
        {
            Console.WriteLine("The number is odd." + number);
        }
    }
}
