namespace a_struct;

struct Employee
{
    public int eid;

    public void displayEID(int eid)
    {
        Console.WriteLine("Employee ID = " + eid);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // emploee e1 = new employee();
        Employee e1;
        e1.eid= 10111010;
        e1.displayEID(e1.eid);
    }
}