namespace c_return_statement;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if (password != "1234")
        {
            Console.WriteLine("Wrong Password");
            return;
        }

        Console.WriteLine("Login Successful");
    }
}
