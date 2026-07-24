using System.Runtime.CompilerServices;

namespace g_exception_handling;

class MyException : Exception
{
    public MyException(string str)
    {
        Console.WriteLine(str);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyException obj = new MyException("This is user defined exception.");
        try
        {
            throw obj;
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
