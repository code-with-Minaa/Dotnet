namespace d_static_class_method_variable;

static class College
{
    public static string CollegeName = "Sanothimi";
    public static void DisplayCollege()
    {
        Console.WriteLine("College Name: " + CollegeName);
    }
}

class Student
{
    public static int Roll = 101;
    public string Name = "Mina";
    public static void DisplayRoll()
    {
        Console.WriteLine("Roll Number: " + Roll);
    }
    public void DisplayName()
    {
        Console.WriteLine("Student Name: " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.DisplayName();
        Student.DisplayRoll();
        College.DisplayCollege();
    }
}