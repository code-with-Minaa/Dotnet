using System.Security.Cryptography.X509Certificates;

namespace e_multicast_delegate;

public delegate void MyDel(int a, int b);
class Calc
{

        public void add (int a, int b)
        {
            Console.WriteLine("The sum = " + (a+b));
        }
        public void mul (int a, int b)
        {
            Console.WriteLine("The product = " + (a*b));
        }
        static void Main(string[] args)
        {
            Calc obj = new Calc();
            MyDel d1 = new MyDel(obj.add);
            MyDel d2 = new MyDel(obj.mul);
            d1 = d1 + d2;
            d1(5,10);
        }
}

