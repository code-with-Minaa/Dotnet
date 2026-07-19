namespace k_constructor_parameterized_ths_keyword;

class Employee
{
    string name;
    int eid;
    public Employee(string name, int eid)
    {
        this.name = name;
        this.eid = eid;
    }
    static void Main(string[] args)
    {
        Employee employee = new Employee("Priyanka Karki", 111);
        Console.WriteLine(employee.name + " " + employee.eid);
    }
}
