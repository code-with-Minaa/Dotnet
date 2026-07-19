namespace f_constructor_overloading_diff_no_of_parameter;

class Calculator
{
    int length, breadth;
    int num1, num2, num3;

    public Calculator(int l, int b)
    {
        length = l;
        breadth = b;
    }

    public Calculator(int a, int b, int c)
    {
        num1 = a;
        num2 = b;
        num3 = c;
    }

    public void DisplayArea()
    {
        Console.WriteLine("Area = " + (length * breadth));
    }

    public void DisplayAverage()
    {
        Console.WriteLine("Average = " + (num1 + num2 + num3) / 3.0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator obj1 = new Calculator(10, 5);
        Calculator obj2 = new Calculator(15, 20, 25);

        obj1.DisplayArea();
        obj2.DisplayAverage();
    }
}
