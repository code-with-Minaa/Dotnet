namespace d_hashtable;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("name","mina");
        hashtable.Add("address","Kadaghari");
        hashtable.Add("age","22");


        Console.WriteLine("Hash Table elements are : ");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }
    }
}
