namespace i_dictionary_tk_tv;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> rollnames = new Dictionary<int, string>();
        rollnames.Add(12,"Ram");
        rollnames.Add(13,"Hari");
        rollnames.Add(14,"Shyam");
        
        foreach (KeyValuePair<int,string> kvp in rollnames)
        {
            Console.WriteLine("Key is {0} and the value is {1}",kvp.Key,kvp.Value);
        }
    }
}
