namespace d_single_cast_delegate;

public class Program
{
    public delegate void Delegatemethod();
    class MyClass
    {
        public static void display()
        {
            Console.WriteLine("Hello Kathmandu");
        }
        public static void show()
        {
            Console.WriteLine("Hello Bhaktapur");
        }
        public void print()
        {
            Console.WriteLine("Hello Lalitpur");
        }
        static void Main(string[] args)
        {
            Delegatemethod d1 = MyClass.display;
            d1();
            Delegatemethod d2 = new Delegatemethod(MyClass.show);
            d2();
            MyClass obj = new MyClass();
            Delegatemethod d3 = obj.print;
            d3.Invoke();
        }
    }
}
