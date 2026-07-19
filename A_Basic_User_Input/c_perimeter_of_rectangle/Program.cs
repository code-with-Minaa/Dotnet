namespace c_perimeter_of_rectangle;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Length : ");
        int l = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Breadth : ");
        int b = Convert.ToInt32(Console.ReadLine());

        int perimeter = 2 * (l + b);

        Console.WriteLine("The perimeter of a rectangle is : " + perimeter);
    }
}
