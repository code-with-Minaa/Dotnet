namespace e_string_fname_lname_address;

class Program
{
    static void Main(string[] args)
    {
        string fname = "Deep";
        string lname = "Basnet";
        string address = "Kathmandu";
        Console.WriteLine(fname + " " + lname + " lives in " + address);
        Console.WriteLine("{0} {1} lives in {2}", fname, lname, address);
    }
}
