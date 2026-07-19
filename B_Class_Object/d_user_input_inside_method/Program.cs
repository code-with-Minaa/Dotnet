namespace d_user_input_inside_method;

class Employee
{
    string? name;
    int eid;
    string? address;

    public void input()
    {
        Console.WriteLine("Enter your name : ");
        name = Console.ReadLine();
        Console.WriteLine("Enter your Employee ID : ");
        eid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your address : ");
        address = Console.ReadLine();

    }

    public void display()
    {
        Console.WriteLine("Your name is : " +name);
        Console.WriteLine("Your employee ID is : " +eid);
        Console.WriteLine("Your address is : " +address);
    }
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.input();
        e1.display();
    }
}
