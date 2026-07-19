namespace h_constructor_overloading_by_diff_data_types;


class Details
{
    int id;
    double salary;
    string name;

    // First Constructor
    public Details(int i, double s)
    {
        id = i;
        salary = s;
    }

    // Second Constructor
    public Details(int i, string n)
    {
        id = i;
        name = n;
    }

    public void ShowSalary()
    {
        Console.WriteLine("ID + Salary = " + (id + salary));
    }

    public void ShowName()
    {
        Console.WriteLine("Employee Name: " + name + " | ID: " + id);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Details obj1 = new Details(101, 35000.50);
        obj1.ShowSalary();

        Details obj2 = new Details(102, "Mina");
        obj2.ShowName();
    }
}
