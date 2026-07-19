namespace a_enum;

class Program
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    static void Main(string[] args)
    {
        // Convert enum to integer
        int monthNumber = (int)Months.December;
        Console.WriteLine(monthNumber);

        // Convert integer to enum
        var month = (Months)4;
        Console.WriteLine(month);
    }
}