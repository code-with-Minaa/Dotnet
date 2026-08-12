namespace h_hashset_t_string;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>();
        names.Add("Mina");
        names.Add("Bina");
        names.Add("Rina");
        names.Add("Tina");
        names.Add("Ena");
        names.Add("Dina");

        // to remove an element
        names.Remove("Mina");
        Console.WriteLine("Elements in hashset : ");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

        // clear function removes all the hash elements.
        names.Clear();
        Console.WriteLine("Elements in hashset after clear function : ");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
