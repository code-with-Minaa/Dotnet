namespace b_static_method;

class Student
{
    // Instance field
    public int a = 9;

    // Static field
    public static int b = 10;

    // Instance method
    public void DisplayInstanceMethod()
    {
        Console.WriteLine("The value of a = " + a);
        Console.WriteLine("The value of b = " + b);
    }

    // Static method
    public static void DisplayStaticMethod()
    {

        Console.WriteLine("The value of b = " + b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student obj = new Student();
        obj.DisplayInstanceMethod();
        Student.DisplayStaticMethod();
    }
}