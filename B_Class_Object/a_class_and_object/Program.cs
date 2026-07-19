namespace a_class_and_object;
#nullable disable
class Employee
{
    int eid; 
    public void input()
    {
        eid = 10;
    }
    public void display()
    {
        Console.WriteLine("Employee ID : " + eid);
    }

    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.input();
        e1.display();
    }
}
