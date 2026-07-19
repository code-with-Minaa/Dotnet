namespace b_struct;

struct Student
{
    public int roll;
    public string name;
    public int age;
    public string address;

}
class Program
{
    static void Main(string[] args)
    {
        Student s1, s2;

        s1.roll = 2;
        s1.name = "Dibya";
        s1.age = 7;
        s1.address = "Kadaghari";

        s2.roll = 8;
        s2.name = "Deep";
        s2.age = 11;
        s2.address = "Kadaghari";


        Console.WriteLine("Roll number of Student one = " + s1.roll);
        Console.WriteLine("Name of Student one = " + s1.name);
        Console.WriteLine("Age of Student one = " + s1.age);
        Console.WriteLine("Address of Student one = " + s1.address);
        Console.WriteLine();
        Console.WriteLine("Roll number of Student two = " + s2.roll);
        Console.WriteLine("Name of Student two = " + s2.name);
        Console.WriteLine("Age of Student two = " + s2.age);
        Console.WriteLine("Address of Student two = " + s2.address);
    }
}