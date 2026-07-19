namespace c_struct;

struct Student
{
    public int id;
    public string name;
    public string department;
    public string city;

    public void GetDetails(int i, string n, string d, string c)
    {
        id = i;
        name = n;
        department = d;
        city = c;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Student ID = {0}", id);
        Console.WriteLine("Name = {0}", name);
        Console.WriteLine("Department = {0}", department);
        Console.WriteLine("City = {0}", city);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student st1 = new Student();
        Student st2 = new Student();

        st1.GetDetails(101, "Mina", "BICTE", "Bhaktapur");
        st2.GetDetails(102, "Rina", "BCA", "Kathmandu");

        st1.DisplayDetails();

        Console.WriteLine();

        st2.DisplayDetails();
    }
}