namespace d_you_can_vote_or_not;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 18)
        {
            Console.WriteLine("You can vote " + age);
        }
        else
        {
            Console.WriteLine("You can not vote " + age);
        }
    }
}

