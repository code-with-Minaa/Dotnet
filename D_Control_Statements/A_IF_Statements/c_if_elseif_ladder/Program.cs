namespace c_if_elseif_ladder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number less than 100 : ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 100)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is a even number smaller than 100.");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine(number + " is a odd number smaller than 100.");
            }
        }
        else
        {
            Console.WriteLine("Something went wrong !");
        }
    }
}
