namespace n_sortedlist_tk_tv_string;

class Program
{
    static void Main(string[] args)
    {
        SortedList<string, string> cities = new SortedList<string, string>()
        {
            {"Nepal","Kathmandu"},
            {"India","New Delhi"},
            {"Japan","Tokyo"}
        };

        foreach (var item in cities)
        {
            Console.WriteLine("{0} is the capital city of {1}.", item.Value, item.Key);
        }
    }
}
