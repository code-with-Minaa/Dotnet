namespace d_exception_handling;


class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Mina", "Rina", "Bina" };
        try
        {
            // Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception found " + e);
        }
    }
}
