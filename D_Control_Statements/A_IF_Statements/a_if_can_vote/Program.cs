namespace a_if_can_vote;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter your age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 18 )
        {
            Console.WriteLine("You can vote. \nYour age is : " + age);
        }
    }
}
