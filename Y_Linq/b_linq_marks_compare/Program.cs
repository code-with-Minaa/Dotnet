namespace b_linq_marks_compare;
class Program
{
    static void Main(string[] args)
    {
        int [] marks1 = new int [] {65,88,12,32,65,75,47,89,99,23};
        int [] marks2 = new int [] {12,78,12,3,9,66,98,42,15,75,76,65};
        var resultSet = from a in marks1 from b in marks2 where a < b select new {a,b};
        foreach (var item in resultSet)
        {
            Console.WriteLine("{0} is less than {1}",item.a, item.b);
        }
    }
}

