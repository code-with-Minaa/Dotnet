namespace a_area_of_rectangle;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Length :");
        int l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter breadth :");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The area of rectangle is :" +(l*b));
    }
}
