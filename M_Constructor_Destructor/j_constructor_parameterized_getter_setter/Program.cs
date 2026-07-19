namespace j_constructor_parameterized_getter_setter;

class Woman
{
    public string FirstName{ get; set; }
    public string LastName{ get; set; }

    public Woman(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }
    static void Main(string[] args)
    {
        Woman w = new Woman("Mina", "Karki");
        Console.WriteLine(w.FirstName + " " + w.LastName);
    }
}
