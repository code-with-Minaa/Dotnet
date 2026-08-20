namespace e_linq_enum_marks;

class Program
{
    static void Main(string[] args)
    {
        int [] marks = {12,59,36,40,42,86,91,75};
        //var marksQuery = from mark in marks where mark >= 80 select mark;
        IEnumerable <int> marksQuery = from mark in marks where mark >= 80 select mark;
        foreach (var mark in marksQuery)
        {
            Console.WriteLine(mark);
        }
    }

}