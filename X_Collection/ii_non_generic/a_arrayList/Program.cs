namespace a_arrayList;
 
using System.Collections; 
class Program
{
    static void Main(string[] args)
    {
        ArrayList namelist = new ArrayList();
        namelist.Add("Sara");
        namelist.Add("Yumna");
        namelist.Add("Hania");
        namelist.Add("Bilal");
        namelist.Add("25");
        namelist.Add("23.85");
        namelist.Add("Wahaj");
        
        /* foreach (var item in namelist)
        {
            Console.WriteLine(item);
        } */

        /* foreach (var item in namelist)
        {
            Console.WriteLine("Name is = " + item);
        } */

        /* foreach (var item in namelist)
        {
            string arrayNames = string.Format($"Name ia {item}");
            Console.WriteLine(arrayNames);
        } */

        Console.WriteLine("Before Update List");
        for (int i = 0; i < namelist.Count; i++)
        {
            Console.WriteLine(namelist[i]);
        }

        namelist.Insert(1,"Sejal");
        namelist.Remove(25);

        Console.WriteLine("Updated List");
        for (int i = 0; i < namelist.Count; i++)
        {
            Console.WriteLine(namelist[i]);
        }
    }
}
