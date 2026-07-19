namespace c_parameterized_constructor;
#nullable disable
class Student
{
    public int roll;
    public string name;
    public string address;

    public Student(int r, string n, string a)
    {
        roll = r;
        name = n;
        address = a;
    }

    public void display()
    {
        Console.WriteLine("Roll = " + roll);
        Console.WriteLine("Name = " + name);
        Console.WriteLine("Address = " + address);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(1,"Mina","Ktm");
        s1.display();
    }
}
