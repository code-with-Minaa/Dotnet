namespace f_static_multicast_delegate;

public delegate void MyDel(int a, int b);
class Calc
{

        public static void add (int a, int b)
        {
            Console.WriteLine("The sum = " + (a+b));
        }
        public static void mul (int a, int b)
        {
            Console.WriteLine("The product = " + (a*b));
        }
        static void Main(string[] args)
        {
            MyDel d1 = new MyDel(Calc.add);
            MyDel d2 = new MyDel(Calc.mul);
            d1 = d1 + d2;
            d1(5,10);
        }
}
