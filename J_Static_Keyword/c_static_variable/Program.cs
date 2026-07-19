namespace c_static_variable;

class Student
{
    public static int roll = 1;
    public static string name = "Dibya";
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object
        Student s1 = new Student();

        // Accessing static variables using the class name
        Console.WriteLine("Roll = " + Student.roll);
        Console.WriteLine("Name = " + Student.name);
    }
}
