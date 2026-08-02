namespace c_lambda;

delegate int myDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        myDel d = (a,b) => (a>b)?a:b;
        int value = d(5,10);
        Console.WriteLine("The greatest number is = " + value);
    }
}

