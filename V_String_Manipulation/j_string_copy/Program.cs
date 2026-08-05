namespace j_string_copy;

class Program
{
    static void Main(string[] args)
    {
        string clg = "Sanothimi";
        // string myclg = string.Copy(clg); // not recommended to use
        string myclg = new string(clg);
        Console.WriteLine("Source string =" + clg);
        Console.WriteLine("Copied string =" + myclg);
    }
}