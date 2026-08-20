namespace a_linq_name_sort;

class Program
{
    static void Main(string[] args)
    {
        string [] students = {"Ram" , "Hari" , "Gita" , "Rina" , "Bina" , "Dina" , "Bima"};
        var nameSort = from name in students orderby name select name;
        foreach (var name in nameSort)
        {
            Console.WriteLine(name);
        }
    }
}
