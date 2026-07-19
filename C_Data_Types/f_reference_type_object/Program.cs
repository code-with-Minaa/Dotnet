namespace f_reference_type_object;

class Program
{
    static void Main(string[] args)
    {
        object data;

        data = "Suman";

        Console.WriteLine("Value: " + data);
        Console.WriteLine("Type: " + data.GetType());
    }
}
