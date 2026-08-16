//Generic collection with delegate
namespace o_generic_with_delegate;

class Program
{
    delegate T Add<T>(T a, T b);
    static void Main(string[] args)
    {
        Add <int> intResult = FunctionOne;
        Console.WriteLine("The sum = {0}", intResult(25,45));
        Add <string> stringResult = FunctionTwo;
        Console.WriteLine("The Conctenated string = {0}", stringResult("Ram ", "Thapa"));
        Add <Double> doubleResult = FunctionThree;
        Console.WriteLine("The sum = {0}", doubleResult(25.22,45.33));
    }

    static int FunctionOne (int x, int y)
    {
        return (x + y);
    }

    static string FunctionTwo (string x, string y)
    {
        return (x + y);
    }

    static double FunctionThree (double x, double y)
    {
        return (x + y);
    }
}
