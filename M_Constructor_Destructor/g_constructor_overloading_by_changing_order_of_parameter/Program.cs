namespace g_constructor_overloading_by_changing_order_of_parameter;

class Employee
{
    public int id;
    public string name;
    public double salary;

    // First constructor
    public Employee(int i, string n, double s)
    {
        id = i;
        name = n;
        salary = s;
    }

    // Second constructor (same parameter types, different order)
    public Employee(double s, int i, string n)
    {
        salary = s;
        id = i;
        name = n;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID = " + id);
        Console.WriteLine("Name = " + name);
        Console.WriteLine("Salary = " + salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee(101, "Mina", 45000);
        Employee emp2 = new Employee(55000, 102, "Rins");

        Console.WriteLine("First Constructor");
        emp1.Display();

        Console.WriteLine();

        Console.WriteLine("Second Constructor");
        emp2.Display();
    }
}
