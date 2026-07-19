namespace i_copy_constructor;

class Student
{
    string name;
    int id;

    // parameterized constructor
    public Student(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
    
    // copy constructor
    public Student(Student s)
    {
        this.name = s.name;
        this.id = s.id;
    }

    public void getData()
    {
        Console.WriteLine("Name = {0}", name);
        Console.WriteLine("ID = {0}", id);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Mina Karki", 10);
        s1.getData();
        Student s2 = new Student(s1); // new object
        s2.getData();
    }
}
