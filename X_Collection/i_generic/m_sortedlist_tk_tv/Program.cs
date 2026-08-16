namespace m_sortedlist_tk_tv;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        SortedList<int,string> rollnames = new SortedList<int, string>();
        rollnames.Add(1,"Sita");
        //rollnames.Add(1,"Jina");
        rollnames.Add(10,"Gita");
        rollnames.Add(12,"Rina");
        rollnames.Add(5,"Bina");
        rollnames.Add(3,"Tina");
        rollnames.Add(8,null);
        rollnames.Add(4,"Rojina");

        rollnames[8] = "Sima"; // assign with a value if value is not there
        rollnames[1] = "Sajana"; //update a value

        Console.WriteLine(rollnames[4]); //Rojina

        foreach (var item in rollnames)
        {
            Console.WriteLine("Key is {0} and value is {1}",item.Key, item.Value);
        }

        /* //The following will exceptions
        rollnames.Add("Binu",13); //compile time exception
        rollnames.Add(1,"Sita"); //run time exception
        rollnames.Add(null,"Alisha"); */
    }
}
