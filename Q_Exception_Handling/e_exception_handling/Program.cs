namespace e_exception_handling;

class Program
{
    static void Main(string[] args)
    {
        // string value = null;
        string value = "Shyam";
        try
        {
            // if(value.Length == 0){
            if(value.Length != 0){
                Console.WriteLine(value);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception found " + e);
        }
    }
}
