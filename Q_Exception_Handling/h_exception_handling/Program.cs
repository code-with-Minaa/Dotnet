namespace h_exception_handling;

class InvalidVoter : Exception
{
    public InvalidVoter(string message) : base (message) {}
}
class Program
{
    static void AgeValidator(int age)
    {
        if (age < 18)
        {
            throw new InvalidVoter ("You are not eligible to get your voter ID by age.");
        }
        else
        {
            Console.WriteLine("You are eligible to get voter ID by your age.");
        }
    }
    static void Main(string[] args)
    {
       Console.WriteLine("Enter your age : ");
       int a = Convert.ToInt32(Console.ReadLine());
        try
        {
            AgeValidator(a);
        }catch (InvalidVoter e)
        {
            Console.WriteLine(e);
        }
    }
}

