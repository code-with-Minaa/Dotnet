namespace c_class_and_object_user_input;
#nullable disable
class Addition
{
    int a;
    int b;
    static void Main(string[] args)
    {
        Addition a1 = new Addition();
        Console.WriteLine("Enter the value of a:");
        a1.a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b:");
        a1.b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of a and b is : " +(a1.a+a1.b));
    }
}
